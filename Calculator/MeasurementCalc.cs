using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MeasurementCalc
    {
        public bool DecimalPressed { get; set; }

        public string[] metricVolume = { "milliliter", "liter", "cubic meter" };
        public string[] metricWeight = { "milligram", "gram", "kilogram" };
        public string[] metricDistance = { "millimeter", "centimeter", "meter", "kilometer" };
        public string[] usVolume = { "fluid oz", "pint", "gallon" };
        public string[] usWeight = { "ounce", "pound" };
        public string[] usDistance = { "inch", "foot", "yard", "mile" };
        public Dictionary<string, string[]> us;
        public Dictionary<string, string[]> metric;

        public MeasurementCalc()
        {
            us = new Dictionary<string, string[]>
            {
                { "Volume", usVolume },
                { "Weight", usWeight },
                { "Distance", usDistance }
            };
            metric = new Dictionary<string, string[]>
            {
                { "Volume", metricVolume },
                { "Weight", metricWeight },
                { "Distance", metricDistance }

            };
        }

    }
}
