using GenAlg.Enums;
using System;

namespace GenAlg.Entites.AreaObjects
{
    public class Bot : AreaObj
    {
        public event Action<MoveDirection, Bot> IWantMove;
        public Bot()
        {
            Type = TypeOfAreaObj.Bot;
        }

        public void Move(MoveDirection md)
        {
            switch (md)
            {
                case MoveDirection.Left:
                    X -= 1;
                    break;
                case MoveDirection.Right:
                    X += 1;
                    break;
                case MoveDirection.Up:
                    Y -= 1;
                    break;
                case MoveDirection.Down:
                    Y += 1;
                    break;
                case MoveDirection.LeftUp:
                    Y -= 1;
                    X -= 1;
                    break;
                case MoveDirection.LeftDown:
                    Y += 1;
                    X -= 1;
                    break;
                case MoveDirection.RightUp:
                    Y -= 1;
                    X += 1;
                    break;
                case MoveDirection.RightDown:
                    Y += 1;
                    X += 1;
                    break;
                
            }

        }
    }
}
