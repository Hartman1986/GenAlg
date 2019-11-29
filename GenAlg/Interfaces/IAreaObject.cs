using GenAlg.Entites;
using GenAlg.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlg.Interfaces
{
    /// <summary>
    /// Объект который может существовать
    /// </summary>
    public interface IAreaObject
    {
        /// <summary>
        /// Тип существующего объекта
        /// </summary>
        public TypeOfAreaObj Type { get; }
        /// <summary>
        /// Координаты существующего объекта
        /// </summary>
        public Coordinates Position { get; set; }
        
    }
}
