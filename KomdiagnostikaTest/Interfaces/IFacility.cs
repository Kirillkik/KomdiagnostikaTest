using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KomdiagnostikaTest.Interfaces
{
    public interface IFacility
    {
        public string Name { get; set; }
        public ObservableCollection<IAggregate> Aggregates { get; set; }
        public State State { get; }
    }
}
