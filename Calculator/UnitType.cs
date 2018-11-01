// Author: Jason Oehlberg
// Program: Calculator
// Date: 2018.10.31

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UnitType
    {
        // private fields holding the Class data
        private string name;
        private double conversion;
        private bool isMetric;

        // Properties to retrieve and set values
        public string Name { set { Name = name; } get { return name; } }
        public double Conversion { set { Conversion = conversion; } get { return conversion; } }
        public bool IsMetric { set { IsMetric = isMetric; } get { return isMetric; } }

        // Constructor to initalize an instance of the UnitType
        public UnitType(string name, double conversion, bool isMetric)
        {
            this.name = name;
            this.conversion = conversion;
            this.isMetric = isMetric;
        }
    }
}
