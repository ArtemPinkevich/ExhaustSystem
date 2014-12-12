using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silencer
{
    /// <summary>
    /// Класс Выхлопная система
    /// </summary>
    public class ExhaustSystem
    {

        #region Переменные

        /// <summary>
        /// Глушитель
        /// </summary>
        private Silencer _silencer = new Silencer();

        /// <summary>
        /// Входящая труба
        /// </summary>
        private Pipe _inputPipe = new Pipe();

        /// <summary>
        /// Выходящаятруба
        /// </summary>
        private Pipe _outputPipe = new Pipe();

        #endregion

        #region Set/Get (Property)

        /// <summary>
        /// Глушитель
        /// </summary>
        public Silencer Silencer
        {
            get { return _silencer; }
            set { _silencer = value; }
        }

        /// <summary>
        /// Входящая труба
        /// </summary>
        public Pipe InputPipe
        {
            get { return _inputPipe; }
            set { _inputPipe = value; }
        }

        /// <summary>
        /// Выходящаятруба
        /// </summary>
        public Pipe OutputPipe
        {
            get { return _outputPipe; }
            set { _outputPipe = value; }
        }

        #endregion

        /// <summary>
        /// Проверка данных
        /// </summary>
        /// <returns>Строка с ошибками (если есть)</returns>
        public String CheckData()
        {
            String _str = "Ошибки в параметрах:\n";
            
            if ((this._outputPipe.Diameter > this._silencer.Width)
                || (this._outputPipe.Diameter > this._silencer.Height))
            {
                _str += "- Внешний диаметр выходящей трубы должен быть меньше ширины/высоты глушителя\n";
            }
            
            if ((this._inputPipe.Diameter > this._silencer.Width)
                || (this._inputPipe.Diameter > this._silencer.Height))
            {
                _str += "- Внешний диаметр входящей трубы должен быть меньше ширины/высоты глушителя\n";
            }
            
            if (this._outputPipe.Diameter <= this._outputPipe.InnerDiameter)
            {
                _str += "- Внутренний диаметр выходящей трубы должен быть меньше внешнего\n";
            }

            if (this._inputPipe.Diameter <= this._inputPipe.InnerDiameter)
            {
                _str += "- Внутренний диаметр входящей трубы должен быть меньше внешнего\n";
            }

            if (this._inputPipe.Bend.Radius <= (this._inputPipe.Diameter / 2))
            {
                _str += "- Радиус изгиба не должен быть меньше половины внешнего диаметра\n";
            }

            if (this._inputPipe.Bend.Angle > 180)
            {
                _str += "- Угол изгиба не должен превышать 180 градусов\n";
            }

            return _str;
        }
    }
}
