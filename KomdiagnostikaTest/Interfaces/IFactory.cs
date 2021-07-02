using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KomdiagnostikaTest.Interfaces
{
    public interface IFactory
    {
        public string Name { get; set; }
        public ObservableCollection<IFacility> Facilities { get; set; }
        public State State { get { return Facilities.Max(x => x.State); }  }
    }
}
