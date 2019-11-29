using GenAlg.Enums;
using GenAlg.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            set { x = value; OnPropertyChanged("X"); }
        }
        public int Y
        {
            get => y;
            set { y = value; OnPropertyChanged("Y"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
