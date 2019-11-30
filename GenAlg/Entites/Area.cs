﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using GenAlg.Entites.AreaObjects;
using GenAlg.Enums;

namespace GenAlg.Entites
{/// <summary>
/// Поле обектов. Унаследовано от ObservableCollection
/// </summary>
/// <typeparam name="IAreaObject">Объект реализующий интерфейс IAreaObject</typeparam>
    public class AreaCollection : ObservableCollection<AreaObj>
    {
        /// <summary>
        /// Ширина поля
        /// </summary>
        public int SizeX { get; set; }
        /// <summary>
        /// Высота поля
        /// </summary>
        public int SizeY { get; set; }

        public AreaCollection(int x, int y)
        {
            SizeX = x;
            SizeY = y;

        }
        public new void Add(AreaObj areaObj)
        {
            if (areaObj?.X > SizeX) throw new ArgumentOutOfRangeException(areaObj.X.ToString(),"Координата X не может быть больше поля");
            if (areaObj?.Y > SizeY) throw new ArgumentOutOfRangeException(areaObj.Y.ToString(), "Координата Y не может быть больше поля");

            if (this.First(item => item.X == areaObj.X && item.Y == areaObj.Y) == null) {
                base.Add(areaObj);
            }
            else { throw new InvalidOperationException("Невозможно добавить объект по заданным координатам. Ячейка не пуста"); }

            base.Add(areaObj);
            
            if(areaObj is Bot)
            {
                Bot bot = areaObj as Bot;
                bot.IWantMove += BotMove;
            }

            
        }

        private void BotMove(MoveDirection moveDirection, Bot sender)
        {
            if (moveDirection == MoveDirection.Right || moveDirection == MoveDirection.RightDown || moveDirection == MoveDirection.RightUp)
            {
                if (sender.X > SizeX - 1) return;
            }
            if (moveDirection == MoveDirection.Down || moveDirection == MoveDirection.LeftDown || moveDirection == MoveDirection.RightDown)
            {
                if (sender.Y > SizeY - 1) return;
            }

            sender.Move(moveDirection);
        }
    }
}
