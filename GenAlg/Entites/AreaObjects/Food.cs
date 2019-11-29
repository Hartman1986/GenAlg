using GenAlg.Enums;
using GenAlg.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlg.Entites.AreaObjects
{
    public class Food : IAreaObject
    {
        public TypeOfAreaObj Type => TypeOfAreaObj.Food;

        public int X { get; set; }
        public int Y { get; set; }
    }
}
