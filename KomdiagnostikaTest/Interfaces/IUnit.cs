using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KomdiagnostikaTest.Interfaces
{
    public interface IUnit
    {
        public string Name { get; set; }
        public ObservableCollection<IUnit> Units { get; set; }
        public ObservableCollection<ISensor> Sensors { get; set; }
        public State State { get; }
    }
}
