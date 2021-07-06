using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KomdiagnostikaTest.Interfaces
{
    public interface ISensor
    {
        public string Name { get; set; }
        public ObservableCollection<IParameter> Parameters { get; set; }
        public State State { get; }
    }
}
