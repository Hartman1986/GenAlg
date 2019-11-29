using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenAlg.Entites.AreaObjects;
using GenAlg.Interfaces;

namespace GenAlg.Entites
{/// <summary>
/// Поле обектов. Унаследовано от ObservableCollection
/// </summary>
/// <typeparam name="IAreaObject">Объект реализующий интерфейс IAreaObject</typeparam>
    public class AreaCollection : ObservableCollection<IAreaObject>
    {
        /// <summary>
        /// Ширина поля
        /// </summary>
        public int SizeX { get; set; }
        /// <summary>
        /// Высота поля
        /// </summary>
        public int SizeY { get; set; }
        
    }
}
