using KomdiagnostikaTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KomdiagnostikaTest.UI.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Parameter speed = new Parameter { Name = "Скорость", Value = 10, State = Enums.State.Norm };
        private Sensor tempretureSensor = new Sensor { Name = "Температура" };

        public MainWindowViewModel()
        {
            TempretureSensor.Parameters.Add(speed);
        }

        public Parameter Speed
        {
            get { return speed; }
            set
            {
                speed = value;
                OnPropertyChanged(nameof(Speed));
            }
        }

        public Sensor TempretureSensor
        {
            get { return tempretureSensor; }
            set
            {
                tempretureSensor = value;
                OnPropertyChanged(nameof(TempretureSensor));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
