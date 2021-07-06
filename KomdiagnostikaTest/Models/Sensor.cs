using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Interfaces;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace KomdiagnostikaTest.Models
{
    public class Sensor : ISensor, INotifyPropertyChanged
    {
        public Sensor()
        {
            Parameters.CollectionChanged += ItemsOnCollectionChanged;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ObservableCollection<IParameter> Parameters { get; set; } = new ObservableCollection<IParameter>();
        private void ItemsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (INotifyPropertyChanged item in e.OldItems)
                    item.PropertyChanged -= UpdateState;
            }
            if (e.NewItems != null)
            {
                foreach (INotifyPropertyChanged item in e.NewItems)
                    item.PropertyChanged += UpdateState;
            }
        }

        private State state;
        public State State
        {
            get { return state; }
            private set
            {
                state = value;
                OnPropertyChanged(nameof(State));
            }
        }
        private void UpdateState(object sender, PropertyChangedEventArgs e)
        {
            State = Parameters.Max(x => x.State);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return State.ToString();
        }
    }
}
