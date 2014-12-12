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
    class Connector
    {
        /// <summary>
        /// Объект KOMПАС-3D
        /// </summary>
        private KompasObject _kompas;

        /// <summary>
        /// Интерфейст 3D детали
        /// </summary>
        private ksDocument3D _doc3D;

        /// <summary>
        /// Интерфейс компонента
        /// </summary>
        private ksPart _part;
        
        /// <summary>
        /// Запуск КОМПАС-3D
        /// </summary>        
        public void OpenKompas()
        {
            if (_kompas == null)
            {
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompas = (KompasObject)Activator.CreateInstance(t);
            }

            if (_kompas != null)
            {
                _kompas.Visible = true;
                _kompas.ActivateControllerAPI();
            }
        }

        /// <summary>
        /// Создание детали. Получение интерфейса
        /// </summary>
        /// <returns></returns>
        public ksPart CreatDoc3D()
        {
            try
            {
                _doc3D = _kompas.Document3D();
                _doc3D.Create(false, true);

                // Получаем интерфейс компонента
                // -1 - pTop_Part
                _part = _doc3D.GetPart(-1);

            }
            catch
            {
                MessageBox.Show("Не удалось создать 3D деталь!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return _part;
        }

        /// <summary>
        /// Получить интерфейс построения эллипса
        /// </summary>
        /// <returns></returns>
        public ksEllipseParam GetEllipseParam()
        {
            return _kompas.GetParamStruct((short)Kompas6Constants.StructType2DEnum.ko_EllipseParam);
        }
        
        /// <summary>
        /// Убрать вспомогательные плоскости и оси
        /// </summary>
        public void MakeBeauty()
        {
            _doc3D.hideAllPlanes = true;
            _doc3D.hideAllAxis = true;
            _doc3D.shadedWireframe = false;
        }

    }
}
