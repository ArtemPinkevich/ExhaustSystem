using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kompas6API5;
using Kompas6Constants3D;


namespace Silencer
{
    class ManagerKompas
    {
        /// <summary>
        /// Интерфейс компонента
        /// </summary>
        private ksPart _part;
        
        /// <summary>
        /// Подключатель к компасу
        /// </summary>
        private Connector _connector = new Connector(); 

        /// <summary>
        /// Выхлопная система (модель данных)
        /// </summary>
        private ExhaustSystem _exhaustSystem;
        
        /// <summary>
        /// Построить выхлопную систему
        /// </summary>
        /// <param name="_exhSystem">Данные системы</param>
        public void CreateExhaustSystem(ExhaustSystem _exhSystem)
        {
            // Открыть компас
            _connector.OpenKompas();
            // Получить интерфейс 3D модели
            _part = _connector.CreatDoc3D();

            // Данные с формы
            _exhaustSystem = _exhSystem;

            // Построение основного глушителя
            CreateSilencer();            
            // Построение труб
            CreatDuct();
            InputDuct();                    

            // Скрыть вспомогательные плоскости и оси
            _connector.MakeBeauty();
            // Отсечь поперек
            CutByPlane();
        }
        
        /// <summary>
        /// Создание глушителя (самой коробки)
        /// </summary>
        private void CreateSilencer()
        {
            // Параметры (длина, ширина, высота, диаметры входящей трубы)
            double length = _exhaustSystem.Silencer.Length;
            double width = _exhaustSystem.Silencer.Width;
            double height = _exhaustSystem.Silencer.Height;
            double innerDiameter = _exhaustSystem.InputPipe.InnerDiameter;
            double diameter = _exhaustSystem.InputPipe.Diameter;

            double depth = 1;  // Глубина выдавливания
            if (length < 5)
            {
                depth = length / 20;
            }

            // Получаем интерфейс объекта плоскость XOY
            ksEntity planeXOY = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);

            ksEntity sketch = CreateBaseSilencer(planeXOY, width, height, 0);   // Основа (эллипс)
            MyExtrusion(sketch, depth);   // Выдавливание

            // Оболочка до перегородки
            ksEntity plane = GetPlane(planeXOY, depth, true);           // Новая плоскость
            sketch = CreateBaseSilencer(plane, width, height, depth);   // Элипс
            MyExtrusion(sketch, (length / 4) - (2 * depth));            // Выдавливание

            // Перегородка 1/4
            plane = GetPlane(planeXOY, (length / 4) - depth, true);     // Новая плоскость
            sketch = CreateBaseSilencer(plane, width, height, 0);       // Опять элипс
            MyExtrusion(sketch, depth);                                 // Выдавливание

            // Оболочка после перегородки
            plane = GetPlane(plane, depth, true);                       // Новая плоскость
            sketch = CreateBaseSilencer(plane, width, height, depth);   // Опять элипс
            MyExtrusion(sketch, (length / 4));                          // Выдавливание

            // Трубы внутренние
            plane = GetPlane(planeXOY, (length / 8), true);
            CreatDuct(plane, length / 4, diameter, innerDiameter, 2 * diameter, 0);
            CreatDuct(plane, length * 3 / 8, diameter, innerDiameter, -2 * diameter, 0);
            
            ksEntity planeForMirror = GetPlane(planeXOY, length / 2, true);  // Плоскость для отражения
            Mirror(planeForMirror);    // Отражение           

        }

        /// <summary>
        /// Создание эллипса
        /// </summary>
        /// <param name="plane">Плоскость</param>
        /// <param name="width">Ширина эллипса</param>
        /// <param name="height">Высота эллипса</param>
        /// <param name="depth">Толщина эллипса (если не сплашной)</param>
        /// <returns>Эскиз</returns>
        private ksEntity CreateBaseSilencer(ksEntity plane, double width, double height, double depth)
        {
            // Получаем интерфейс объекта "эскиз"
            ksEntity sketch = _part.NewEntity((short)Obj3dType.o3d_sketch);

            // Получаем интерфейс параметров эскиза
            ksSketchDefinition sketchDefinition = sketch.GetDefinition();

            // Устанавлеваем плоскость XOY базовой для эскиза
            sketchDefinition.SetPlane(plane);

            // Создаем эскиз
            sketch.Create();

            // Входим в режим редактирования эскиза (2D)
            ksDocument2D doc2D = sketchDefinition.BeginEdit();
            // Задаем параметры элипса
            ksEllipseParam ellipseParam = _connector.GetEllipseParam();
            ellipseParam.A = width - depth;     // Ширина
            ellipseParam.B = height - depth;    // Высота
            ellipseParam.angle = 0;    // Угол наклона
            ellipseParam.style = 1;    // Стиль
            ellipseParam.xc = 0;       // Центр х
            ellipseParam.yc = 0;       // Центр у
            // строим элипс
            doc2D.ksEllipse(ellipseParam);

            // Ещё один элипс
            ellipseParam = _connector.GetEllipseParam();
            ellipseParam.A = width;     // Ширина
            ellipseParam.B = height;    // Высота
            ellipseParam.angle = 0;     // Угол наклона
            ellipseParam.style = 1;     // Стиль
            ellipseParam.xc = 0;        // Центр х
            ellipseParam.yc = 0;        // Центр у
            // строим элипс
            doc2D.ksEllipse(ellipseParam);

            // Выходим из режима редактирования эскиза
            sketchDefinition.EndEdit();

            return sketch;
        }

        /// <summary>
        /// Выдавливание
        /// </summary>
        /// <param name="_entity">Эскиз</param>
        /// <param name="length">Глубина выдавливания</param>
        private void MyExtrusion(ksEntity _entity, double length)
        {
            // Получаем интерфейс объекта "Операция выдавливания"
            ksEntity entityExtrusion = _part.NewEntity((short)Obj3dType.o3d_baseExtrusion);

            // Получаем интерфейс параметров операции выдавливания
            ksBaseExtrusionDefinition extrDefinition = entityExtrusion.GetDefinition();
            
            // Устанавливаем параметры операци выдавливания
            extrDefinition.SetSideParam(true, (short)End_Type.etBlind, length); // прямое направление, строго на глубину, глубина

            // Устанавливаем эскиз операции выдавливания
            extrDefinition.SetSketch(_entity);

            // Выдавливаем
            entityExtrusion.Create();
            
        }
        
        /// <summary>
        /// Создание дополнительной плоскости
        /// </summary>
        /// <param name="plane">Базовая плоскость</param>
        /// <param name="offset">Величина смещения</param>
        /// <param name="_direct">Направление</param>
        /// <returns></returns>
        private ksEntity GetPlane(ksEntity plane, double offset, bool _direct)
        {
            // Получаем интерфейс объекта "Смещенная плоскость"
            ksEntity offsetPlane = _part.NewEntity((short)Obj3dType.o3d_planeOffset);

            // Получаем интерфейс параметров объекта "Смещенная плоскость"
            ksPlaneOffsetDefinition offsetPlaneDef = offsetPlane.GetDefinition();
            offsetPlaneDef.direction = _direct;        // Прямое направление смещения
            offsetPlaneDef.offset = offset;           // Величина смещения
            offsetPlaneDef.SetPlane(plane);           // Установка базовой плоскости
            
            offsetPlane.Create();  // Создание плоскости

            return offsetPlane;
        }
        
        /// <summary>
        /// Зеркальное отражение
        /// </summary>
        /// <param name="plane">Плоскость отражения</param>
        private void Mirror(ksEntity plane)
        {
            ksEntity mirror = _part.NewEntity((short)Obj3dType.o3d_mirrorAllOperation);
            ksMirrorCopyAllDefinition mirrorDef = mirror.GetDefinition();

            // Устанавливаем грань
            // в методичке говорилось, что нужно использовать
            // именно грань компонента,
            // но с плоскостью тоже нормально работает
            mirrorDef.SetPlane(plane);
            mirror.Create();
        }
        
        /// <summary>
        /// Создание трубы (выходящей)
        /// </summary> 
        private void CreatDuct()
        {
            // Параметры
            double diameter = _exhaustSystem.OutputPipe.Diameter;
            double innerDiameter = _exhaustSystem.OutputPipe.InnerDiameter;  // Внутренний диаметр
            double length = _exhaustSystem.OutputPipe.Length;

            // Получаем интерфейс объекта плоскость XOY
            ksEntity planeXOY = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);

            // Трубка 1
            ksEntity plane = GetPlane(planeXOY, length, false);
            ksEntity sketch = Hole(plane, diameter, 0, 0);
            MyExtrusion(sketch, length);
            sketch = Hole(plane, innerDiameter, 0, 0);
            MyCutExtrusion(sketch, length);

        }

        /// <summary>
        /// Создание трубы
        /// </summary>
        /// <param name="plane">Плоскость</param>
        /// <param name="length">Длина трубы</param>
        /// <param name="diameter">Внешний диаметр</param>
        /// <param name="innerDiameter">Внутренний диаметр</param>
        /// <param name="x">Смещение по х</param>
        /// <param name="y">Смещение по у</param>
        private void CreatDuct(ksEntity plane, double length, double diameter, double innerDiameter, double x, double y)
        {
            ksEntity sketch = Hole(plane, diameter, x, y);
            MyExtrusion(sketch, length);
            sketch = Hole(plane, innerDiameter, x, y);
            MyCutExtrusion(sketch, length);
        }

        /// <summary>
        /// Отверстие
        /// </summary>
        /// <param name="plane">Плоскость</param>
        /// <param name="innerDiameter">Диаметр</param>
        /// <param name="x">Смещение по х</param>
        /// <param name="y">Смещение по у</param>
        /// <returns></returns>
        private ksEntity Hole(ksEntity plane, double innerDiameter, double x, double y)
        {
            // Получаем интерфейс объекта эскиз
            ksEntity entitySketch = _part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDef = entitySketch.GetDefinition();
            sketchDef.SetPlane(plane);

            entitySketch.Create();
            ksDocument2D doc2D = sketchDef.BeginEdit();
            doc2D.ksCircle(x, y, innerDiameter, 1);
            sketchDef.EndEdit();

            return entitySketch;
        }

        /// <summary>
        /// Вырезание выдавливанием
        /// </summary>
        /// <param name="sketch">Эскиз</param>
        /// <param name="length">Глубина вырезания</param>
        private void MyCutExtrusion(ksEntity sketch, double length)
        {
            // Получаем интерфейс объекта "Операция выдавливания"
            ksEntity entityCutExtrusion = _part.NewEntity((short)Obj3dType.o3d_cutExtrusion);

            // Получаем интерфейс параметров операции выдавливания
            ksCutExtrusionDefinition _extrCutDefinition = entityCutExtrusion.GetDefinition();
            
            _extrCutDefinition.cut = true;
            _extrCutDefinition.directionType = (short)Kompas6Constants3D.ksDirectionTypeEnum.dtBoth;
            // Устанавливаем параметры операци выдавливания
            _extrCutDefinition.SetSideParam(false, (short)End_Type.etBlind, length + 2); // прямое направление, строго на глубину, глубина

            // Устанавливаем эскиз операции выдавливания
            _extrCutDefinition.SetSketch(sketch);

            // Выдавливаем
            entityCutExtrusion.Create();
        }
        
        /// <summary>
        /// Создание входящей трубы (с изгибами)
        /// </summary>
        private void InputDuct()
        {
            // Параметры
            double diameter = _exhaustSystem.InputPipe.Diameter;           // Внешний диаметр трубы
            double innerDiameter = _exhaustSystem.InputPipe.InnerDiameter; // Внутренний диаметр
            double lengthSilencer = _exhaustSystem.Silencer.Length;        // Длина глушителя (для доп.плоскости)
            
            // Дополнительная плоскость (одно из оснований глушителя)
            ksEntity planeXOY = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            ksEntity planeStartDuct = GetPlane(planeXOY, lengthSilencer, true);

            // Отверстие
            Hole(planeStartDuct, innerDiameter, 0, 0);

            // Сечение
            ksEntity section = GetSection(planeStartDuct, diameter, innerDiameter);

            // Траектория
            // Получаем интерфейс объекта плоскость XOZ (для траектории)
            ksEntity planeXOZ = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);
            ksEntity trajectory = GetSketchForBossEvol(planeXOZ, 0, lengthSilencer);

            // Кинемат
            BossEvolution(section, trajectory);

            // Кинемат вырезат
            section = GetSection(planeStartDuct, innerDiameter, innerDiameter);
            CutEvolution(section, trajectory);
        }
        
        /// <summary>
        /// Кинематическое приклеивание
        /// </summary>
        /// <param name="section">Сечение</param>
        /// <param name="trajectory">Траектория</param>
        private void BossEvolution(ksEntity section, ksEntity trajectory)
        {
            ksEntity bossEvolution = _part.NewEntity((short)Obj3dType.o3d_bossEvolution);
            ksBossEvolutionDefinition bossEvolDef = bossEvolution.GetDefinition();
            bossEvolDef.sketchShiftType = 1;    // Тип движения
            bossEvolDef.SetSketch(section);     // Эскиз сечения
            
            // Получаем массив объектов
            ksEntityCollection entityCollection = bossEvolDef.PathPartArray();
            entityCollection.Clear();

            // Добавление в массив эскиз с траекторией
            entityCollection.Add(trajectory);

            bossEvolution.Create();
        }

        /// <summary>
        ///  Кинематическое вырезание
        /// </summary>
        /// <param name="section">Сечение</param>
        /// <param name="trajectory">Траектория</param>
        private void CutEvolution(ksEntity section, ksEntity trajectory)
        {
            ksEntity cutEvolution = _part.NewEntity((short)Obj3dType.o3d_cutEvolution);
            ksCutEvolutionDefinition cutEvolDef = cutEvolution.GetDefinition();
            cutEvolDef.cut = true;
            cutEvolDef.sketchShiftType = 1;
            cutEvolDef.SetSketch(section);    // Сечение

            // Получаем массив объектов
            ksEntityCollection entityCollection = cutEvolDef.PathPartArray();
            entityCollection.Clear();
            entityCollection.Add(trajectory); // Траектория

            cutEvolution.Create();
        }
        
        /// <summary>
        /// Сечение
        /// </summary>
        /// <param name="plane">Плоскость</param>
        /// <param name="diameter">Внешний диаметр</param>
        /// <param name="innerDiameter">Внутренний диаметр</param>
        /// <returns></returns>
        private ksEntity GetSection(ksEntity plane, double diameter, double innerDiameter)
        {
            // Получаем интерфейс объекта эскиз
            ksEntity entitySketch = _part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDef = entitySketch.GetDefinition();
            sketchDef.SetPlane(plane);

            entitySketch.Create();
            ksDocument2D doc2D = sketchDef.BeginEdit();
            doc2D.ksCircle(0, 0, diameter, 1);
            //doc2D.ksCircle(0, 0, innerDiameter, 1);
            sketchDef.EndEdit();

            return entitySketch;
        }

        /// <summary>
        /// Траектория
        /// </summary>
        /// <param name="plane">Плоскость</param>
        /// <param name="xStart">Начальная х</param>
        /// <param name="yStart">Начальная у</param>
        /// <returns></returns>
        private ksEntity GetSketchForBossEvol(ksEntity plane, double xStart, double yStart)
        {
            double lengthBefore = _exhaustSystem.InputPipe.Bend.LengthBefore;
            double radius = _exhaustSystem.InputPipe.Bend.Radius;
            double angle = _exhaustSystem.InputPipe.Bend.Angle;

            double x1;
            double y1;
            double x2;
            double y2;

            ksEntity entitySketch = _part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition sketchDef = entitySketch.GetDefinition();
            sketchDef.SetPlane(plane);
            entitySketch.Create();

            ksDocument2D doc2D = sketchDef.BeginEdit();
            x1 = xStart;
            y1 = yStart;
            x2 = x1;
            y2 = y1 + lengthBefore;

            doc2D.ksLineSeg(x1, -y1, x2, -y2, 1);
            //doc2D.ksArcByPoint(30, -130, 30, 0, -130, 30, -160, 1, 1);


            // Почему то отсчет идет с левой стороны, поэтому надо прибавлять 180
            doc2D.ksArcByAngle(x2 + radius, -y2, radius, 180, 180 + angle, 1, 1);
            //doc2D.ksLineSeg(30, 80, 70, 80, 1);
            sketchDef.EndEdit();

            return entitySketch;
        }
        
        /// <summary>
        /// Отсечение поперек
        /// </summary>
        private void CutByPlane()
        {
            // Плоскость сечения XOZ
            ksEntity plane = _part.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ);

            ksEntity cutByPlane = _part.NewEntity((short)Obj3dType.o3d_cutByPlane);
            ksCutByPlaneDefinition cutByPlaneDef = cutByPlane.GetDefinition();
            cutByPlaneDef.direction = false;
            cutByPlaneDef.SetPlane(plane);
            cutByPlane.Create();
        }

    }
}
