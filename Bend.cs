using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silencer
{
    /// <summary>
    /// Класс изгиб
    /// </summary>
    public class Bend
    {
        /// <summary>
        /// Длина трубы до изгибы
        /// </summary>
        public double LengthBefore {get; set;}

        /// <summary>
        /// Радиус изгиба
        /// </summary>
        public double Radius {get; set;}

        /// <summary>
        /// Угол изгиба
        /// </summary>
        public double Angle {get; set;}
    }
}
