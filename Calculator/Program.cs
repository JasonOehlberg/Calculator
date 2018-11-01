/*
 Author: Jason Oehlberg
 Program: Calculator
 Date: 2018.10.31
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
            
            Application.Run(AppControl.GetForm("StandardCalculator"));
        }


    }
}
