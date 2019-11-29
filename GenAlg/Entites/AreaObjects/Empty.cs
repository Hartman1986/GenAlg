using GenAlg.Enums;
using GenAlg.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlg.Entites.AreaObjects
{
    /// <summary>
    /// Пустой объект
    /// </summary>
    public class Empty : IAreaObject
    {
        public TypeOfAreaObj Type => TypeOfAreaObj.Empty;

        public Coordinates Position { get ; set ; }
        

    }
}
