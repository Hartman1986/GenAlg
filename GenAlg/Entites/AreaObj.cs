using GenAlg.Enums;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GenAlg.Entites
{
    public abstract class AreaObj : INotifyPropertyChanged
    {
        private int x;
        private int y;
        private TypeOfAreaObj type;

        public TypeOfAreaObj Type { 
            get => type; 
            protected set { type = value; OnPropertyChanged("Type"); } 
        }

        public int X
        {
            get => x;
            set {
                if (value < 0) throw new ArgumentOutOfRangeException("Х не может быть меньше 0");
                x = value; 
                OnPropertyChanged("X"); 
            }
        }
        public int Y
        {
            get => y;
            set {
                if (value < 0) throw new ArgumentOutOfRangeException("Y не может быть меньше 0");
                y = value; 
                OnPropertyChanged("Y"); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
