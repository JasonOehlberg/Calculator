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

        private string[] metricVolume = { "milliliter", "liter", "cubic meter" };
        private string[] metricWeight = { "milligram", "gram", "kilogram" };
        private string[] metricDistance = { "millimeter", "centimeter", "meter", "kilometer" };
        private string[] usVolume = { "fluid oz", "pint", "gallon" };
        private string[] usWeight = { "ounce", "pound" };
        private string[] usDistance = { "inch", "foot", "yard", "mile" };

        private readonly Dictionary<string, string[]> us;
        private readonly Dictionary<string, string[]> metric;
        private readonly Dictionary<string, double[]> usConversion;
        private readonly Dictionary<string, double[]> metricConverion;

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

        public string[] getUSList(string id)
        {
            return us[id];
        }

        public string[] getMetricList(string id)
        {
            return metric[id];
        }

        public string convertFromMilli(string s)
        {
            UInt64 temp = Convert.ToUInt64(s);

            return "";
        }

    }
}
