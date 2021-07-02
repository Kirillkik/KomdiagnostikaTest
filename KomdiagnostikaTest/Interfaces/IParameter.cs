using KomdiagnostikaTest.Enums;
using KomdiagnostikaTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KomdiagnostikaTest.Interfaces
{
    public interface IParameter
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public State State { get; set; }
    }
}
