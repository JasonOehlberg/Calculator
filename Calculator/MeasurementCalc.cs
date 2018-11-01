/*
 Author: Jason Oehlberg
 Program: Calculator
 Date: 2018.10.31
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MeasurementCalc
    {
        // Property holding if the Decimal Button has been pressed
        public bool DecimalPressed { get; set; }

        // Dictionaries holding the instances of the UnitType objeccts
        private readonly Dictionary<string, UnitType[]> us;
        private readonly Dictionary<string, UnitType[]> metric;


        public MeasurementCalc()
        {
            // creating instances of the UnitType arrays each with a type discription as the key for easy access in Measurement Converter
            metric = new Dictionary<string, UnitType[]>
            {
                { "Volume", new UnitType[3] { new UnitType("Milliliter", 0.001, true) , new UnitType("Liter", 1, true), new UnitType("Cubic Meter", 1000, true)} },
                { "Weight", new UnitType[3] { new UnitType("Milligram", 0.001, true), new UnitType("Gram", 1, true), new UnitType("Kilogram", 1000, true) } },
                { "Distance", new UnitType[3] { new UnitType("Millimeter", 0.001, true) , new UnitType("Meter", 1, true), new UnitType("Kilometer", 1000, true)}  }
            };
            us = new Dictionary<string, UnitType[]>
            {
                { "Volume", new UnitType[3] { new UnitType("Fluid Ounce", 0.0625, false) , new UnitType("Pint", 1, false), new UnitType("Gallon", 8, false) } },
                { "Weight", new UnitType[3] { new UnitType("Ounce", 0.0625, false) , new UnitType("Pound", 1, false), new UnitType("Ton", 2000, false) } },
                { "Distance", new UnitType[3] { new UnitType("Inch", 0.0833333, false) , new UnitType("Feet", 1, false), new UnitType("Mile", 5280, false) } }
            };
        }

        // returns the US Unit list UnitType array
        public UnitType[] getUSUnitList(string type)
        {
            return us[type];
        }

        // returns the Metric list UnitType array
        public UnitType[] getMetricUnitList(string type)
        {
            return metric[type];
        }

        // returns an ArrayList of strings to populate a ComboBox for US conversion
        public ArrayList getUSList(string id)
        {
            ArrayList temp = new ArrayList();
            foreach(UnitType type in us[id])
            {
                temp.Add(type.Name);
            }
            return temp;
        }

        // returns an ArrayList of strings to populate a ComboBox for Metric conversion
        public ArrayList getMetricList(string id)
        {
            ArrayList temp = new ArrayList();
            foreach (UnitType type in metric[id])
            {
                temp.Add(type.Name);
            }
            return temp;
        }

        // converts a number to its base unit
        public string convert(string value, double conversion)
        {
            double temp = Convert.ToDouble(value);
            return (temp * conversion).ToString();
        }

        //****************************************
        // *******   NEEDS REFACTORING    ********
        //****************************************

        // passes the value from the lblInput compares the type with a string and returns a value multipled with a conversion
        // isMetric decides which unit path it goes down
        public string convertToOtherFormat(string value, string type, bool isMetric)
        {
            double temp = Convert.ToDouble(value);
            if (isMetric)
            {
                Debug.WriteLine("Im in convertToOtherFormat if statement");
                if (type.Equals("Volume"))
                {
                    return (temp * 2.11338).ToString();
                }
                else if (type.Equals("Weight"))
                {
                    return (temp * 0.00220462).ToString();
                }
                else if (type.Equals("Distance"))
                {
                    return (temp * 3.28084).ToString();
                }
                else return "Something went wrong";
            }
            else
            {
                if (type.Equals("Volume"))
                {
                    return (temp * 0.473176).ToString();
                }
                else if (type.Equals("Weight"))
                {
                    return (temp * 453.592).ToString();
                }
                else if (type.Equals("Distance"))
                {
                    return (temp * 0.3048).ToString();
                }
                else return "Something went wrong.";
            }
        }

    }
}
