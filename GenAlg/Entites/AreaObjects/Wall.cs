using GenAlg.Enums;
using GenAlg.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlg.Entites.AreaObjects
{
    public class Wall : IAreaObject
    {
        public TypeOfAreaObj Type => TypeOfAreaObj.Wall;

        public Coordinates Position { get; set; }
    }
}
