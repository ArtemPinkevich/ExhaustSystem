using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Silencer;

namespace UnitTestSilencer
{
    [TestClass]
    public class ExhaustSystemTest
    {
        /// <summary>
        /// Тест корректного ввода
        /// </summary>
        [TestMethod]
        public void CheckDataNormalTest()
        {
            ExhaustSystem exhaustSystem = SetExhaustSystem();

            string resultCheck = exhaustSystem.CheckData();
            Console.WriteLine(resultCheck);

            Assert.AreEqual("Ошибки в параметрах:\n", resultCheck);
        }

        /// <summary>
        /// Тест на некорректный параметр диаметра трубы
        /// </summary>
        [TestMethod]
        public void CheckDataDiametrFailTest()
        {
            ExhaustSystem exhaustSystem = SetExhaustSystem();

            // Задаем диаметр трубы больше высоты глушителя
            exhaustSystem.InputPipe.Diameter = exhaustSystem.Silencer.Height + 1; 

            string resultCheck = exhaustSystem.CheckData();

            if (resultCheck == "Ошибки в параметрах:\n")
            {
                Assert.Fail();
            }            
        }

        /// <summary>
        /// Тест на некорректный внутренний диаметр трубы
        /// </summary>
        [TestMethod]
        public void CheckDataInnerDiametrFailTest()
        {
            ExhaustSystem exhaustSystem = SetExhaustSystem();

            // Задаем внутренний диаметр трубы больше внешнего
            exhaustSystem.InputPipe.InnerDiameter = exhaustSystem.InputPipe.Diameter + 1;

            string resultCheck = exhaustSystem.CheckData();

            if (resultCheck == "Ошибки в параметрах:\n")
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Тест на некорректный радиус изгиба
        /// </summary>
        [TestMethod]
        public void CheckDataRadiusFailTest()
        {
            ExhaustSystem exhaustSystem = SetExhaustSystem();

            // Задаем драдиус изгима меньше половины диаметра трубы
            exhaustSystem.InputPipe.Bend.Radius = exhaustSystem.InputPipe.Diameter / 10;

            string _resultCheck = exhaustSystem.CheckData();

            if (_resultCheck == "Ошибки в параметрах:\n")
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Задать параметры выхлопной системы (корректные)
        /// </summary>
        /// <returns></returns>
        public ExhaustSystem SetExhaustSystem()
        {
            ExhaustSystem exhaustSystem = new ExhaustSystem();

            // Глушитель
            exhaustSystem.Silencer.Length = 100;
            exhaustSystem.Silencer.Width = 200;
            exhaustSystem.Silencer.Height = 300;

            // Выходящая труба
            exhaustSystem.OutputPipe.Length = 40;
            exhaustSystem.OutputPipe.Diameter = 70;
            exhaustSystem.OutputPipe.InnerDiameter = 60;

            // Входящая труба
            exhaustSystem.InputPipe.Diameter = 70;
            exhaustSystem.InputPipe.InnerDiameter = 60;

            // Изгиб
            exhaustSystem.InputPipe.Bend.LengthBefore = 90;
            exhaustSystem.InputPipe.Bend.Radius = 100;
            exhaustSystem.InputPipe.Bend.Angle = 110;

            return exhaustSystem;
        }

    }
}
