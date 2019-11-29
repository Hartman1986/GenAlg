using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlg.Entites
{
    /// <summary>
    /// Двумерная система коордитат.
    /// </summary>
    public class Coordinates
    {

        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Конструктор без параметров устанавливает координаты в 0
        /// </summary>
        public Coordinates()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Установка соответствующих значений координат
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}
