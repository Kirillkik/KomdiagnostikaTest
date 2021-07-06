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
        private Sensor tempretureSensor = new Sensor { Name = "Термометр" };
        private Unit bearing = new Unit { Name = "Подшипник" };
        private Unit bearingSupport = new Unit { Name = "Подшипниковая опора" };
        private Aggregate pump = new Aggregate { Name = "Насос" };
        private Facility somethingFacility = new Facility { Name = "Установка" };
        private Factory somethingFactory = new Factory { Name = "Завод" };

        public MainWindowViewModel()
        {
            tempretureSensor.Parameters.Add(speed);
            bearingSupport.Units.Add(bearing);
            bearingSupport.Sensors.Add(tempretureSensor);
            pump.Units.Add(bearingSupport);
            somethingFacility.Aggregates.Add(pump);
            somethingFactory.Facilities.Add(somethingFacility);
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
        public Unit Bearing
        {
            get { return bearing; }
            set
            {
                bearing = value;
                OnPropertyChanged(nameof(Bearing));
            }
        }
        public Unit BearingSupport
        {
            get { return bearingSupport; }
            set
            {
                bearingSupport = value;
                OnPropertyChanged(nameof(BearingSupport));
            }
        }
        public Aggregate Pump
        {
            get { return pump; }
            set
            {
                pump = value;
                OnPropertyChanged(nameof(Pump));
            }
        }
        public Facility SomethingFacility
        {
            get { return somethingFacility; }
            set
            {
                somethingFacility = value;
                OnPropertyChanged(nameof(SomethingFacility));
            }
        }
        public Factory SomethingFactory
        {
            get { return somethingFactory; }
            set
            {
                somethingFactory = value;
                OnPropertyChanged(nameof(SomethingFactory));
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
