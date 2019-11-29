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
    public class Area : ObservableCollection<IAreaObject>
    {
        /// <summary>
        /// Ширина поля
        /// </summary>
        public int SizeX { get; set; }
        /// <summary>
        /// Высота поля
        /// </summary>
        public int SizeY { get; set; }
        /// <summary>
        /// Создать новое поле с заданными размерами
        /// </summary>
        /// <param name="x">Ширина</param>
        /// <param name="y">Высота</param>
        public Area(int x, int y)
        {
            SizeX = x;
            SizeY = y;

            for (int i = 0; i < (x * y) -1; i++)
            {
                Add(new Empty());
            }
        }
        /// <summary>
        /// Добавить новый объект IAreaObject в коллекцию с автоматическим изменением кординат
        /// </summary>
        /// <param name="areaObject">Объект реализующий интерфейс IAreaObject</param>
        public new void Add(IAreaObject areaObject)
        {
            if (IndexOf(this.LastOrDefault()) > SizeX * SizeY ) throw new IndexOutOfRangeException("Превышено количество элементов на поле");
            base.Add(areaObject);
            int index = IndexOf(areaObject);
            int tmpY = 0;
            areaObject.Position = new Coordinates();
            if(index < SizeX)
            {
                areaObject.Position.X = index;
                areaObject.Position.Y = 0;
            }
            else
            {
                while (index >= SizeX)
                {
                    index -= SizeX;
                    tmpY++;
                }
                areaObject.Position.X = index;
                areaObject.Position.Y = tmpY;
            }
            
        }

        public void Insert(IAreaObject areaObject)
        {
            if (areaObject.Position?.X >= SizeX) throw new IndexOutOfRangeException("Координата X вне поля");
            if (areaObject.Position?.Y >= SizeY) throw new IndexOutOfRangeException("Координата Y вне поля");
            if (areaObject.Position == null) areaObject.Position = new Coordinates();
            int index = SizeX * areaObject.Position.Y + areaObject.Position.X;

            if (this[index].Type == Enums.TypeOfAreaObj.Empty)
            {
                RemoveAt(index);
                Insert(index, areaObject);
            }
            
        }

        public void Delete(int x, int y)
        {
            if(x >= SizeX) throw new IndexOutOfRangeException("Координата X вне поля");
            if(y >= SizeY) throw new IndexOutOfRangeException("Координата Y вне поля");
            IAreaObject obj = this.FirstOrDefault(item => item.Position.X == x && item.Position.Y == y);
            if(obj != null && obj.Type != Enums.TypeOfAreaObj.Empty)
            {
                int index = IndexOf(obj);
                RemoveAt(index);
                Insert(index, new Empty());
            }
        }


    }
}
