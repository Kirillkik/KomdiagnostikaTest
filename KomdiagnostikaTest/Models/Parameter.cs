using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KomdiagnostikaTest.Models
{
    public class Parameter : IParameter, INotifyPropertyChanged
    {
        private string name { get; set; }
        private double value { get; set; }
        private State state { get; set; } = State.Norm;

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
