using GenAlg.Enums;
using GenAlg.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenAlg.Entites.AreaObjects
{
    public class Wall : AreaObj
    {
        public Wall()
        {
            Type = TypeOfAreaObj.Wall;
        }
    }
}
