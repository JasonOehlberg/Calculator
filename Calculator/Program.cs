/*
 Jason Oehlberg
 CS.4253 Windows Programming
 Homework 2: Conversion Calculator
 Due: 2018.09.25
 */

using System;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StandardCalculator st = new StandardCalculator();
            Application.Run(st);
        }
    }
}
