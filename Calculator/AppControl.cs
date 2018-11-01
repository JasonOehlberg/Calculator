// Author: Jason Oehlberg
// Program: Calculator
// Date: 2018.10.31


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    // Since Inherited Forms where not used a way to navigate to each Form was needed
    static public class AppControl
    {
        // dictionary holding an instance of each of the forms
        static Dictionary<string, Form> forms = new Dictionary<string, Form>
        {
            { "StandardCalculator", new StandardCalculator() },
            { "MeasurementConverter", new MeasurementConverter() },
            { "ProgrammerView", new ProgrammerView() },
            { "Time", new Time() }
        };

        // Static method to retrieve the form based on the keys of the Dictionary
        static public Form GetForm(string name)
        {
            return forms[name];
        }
    }
}
