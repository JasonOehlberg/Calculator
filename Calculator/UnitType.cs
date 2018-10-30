using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UnitType
    {
        private string name;
        private double conversion;
        private double toOther;
        private bool isMetric;

        public string Name { set { Name = name; } get { return name; } }
        public double Conversion { set { Conversion = conversion; } get { return conversion; } }
        public bool IsMetric { set { IsMetric = isMetric; } get { return isMetric; } }

        public UnitType(string name, double conversion, bool isMetric)
        {
            this.name = name;
            this.conversion = conversion;
            this.isMetric = isMetric;
        }
    }
}
