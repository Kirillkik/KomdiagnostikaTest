using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KomdiagnostikaTest.Models.Parameters
{
    public class Movement : IParameter, INotifyPropertyChanged
    {
        public string name { get; set; }
        public double value { get; set; }
        public State state { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public double Value
        {
            get { return value; }
            set
            {
                this.value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                OnPropertyChanged(nameof(State));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
