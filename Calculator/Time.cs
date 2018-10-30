// Author: Jason Oehlberg

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
   
    public partial class Time : Form
    {
       
        private TimeModel timeModel;
        public Time()
        {
            InitializeComponent();
            // Initializes the title
            this.Text = "Date Time Calculator";
            // No Icon
            this.ShowIcon = false;
            // Instance of the timeModel class
            timeModel = new TimeModel();
        }

        // Sets each label and dateTimePicker to default value
        private void Time_Load(object sender, EventArgs e)
        {
            lblTimeStarted.Text = DateTime.Now.ToLongTimeString();
            dtPickStart.Format = DateTimePickerFormat.Custom;
            dtPickStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtPickEnd.Format = DateTimePickerFormat.Custom;
            dtPickEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }

        // Action for Calculate Button when clicked
        private void btnCalculateTime_Click(object sender, EventArgs e)
        {
            // Calculate the elapse time
            lblTimeElapsed.Text = timeModel.subtractTime(dtPickEnd.Value, dtPickStart.Value);
        }

        // Tick Event for the Timer object to keep populating the time now every second
        private void programTimer_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToLongTimeString();
        }


        // The next four EventListeners check if a menu it has been Clicked
        // If so they open a new form and close this form

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            f.Location = Location;
            Close();
        }

        private void measurementConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementConverter mc = new MeasurementConverter();
            mc.Show();
            mc.Location = Location;
            Close();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            StandardCalculator sc = new StandardCalculator();
            sc.Show();
            sc.Location = Location;
            Close();
        }

       
        
    }
}