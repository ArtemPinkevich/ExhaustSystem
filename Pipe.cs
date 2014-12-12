using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silencer
{
    /// <summary>
    /// Класс Труба
    /// </summary>
    public class Pipe
    {
        /// <summary>
        /// Изгиб трубы
        /// </summary>
        private Bend _bend = new Bend();
        
        /// <summary>
        /// Длина трубы
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Внешний диаметр трубы
        /// </summary>
        public double Diameter { get; set; }

        /// <summary>
        /// Внутренний диаметр трубы
        /// </summary>
        public double InnerDiameter { get; set; }

        /// <summary>
        /// Изгиб трубы
        /// </summary>
        public Bend Bend
        {
            get { return _bend; }
            set { _bend = value; }
        }

    }
}
