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
            this.Text = "Date Time Calculator";
            this.ShowIcon = false;
            timeModel = new TimeModel();
        }

        private void Time_Load(object sender, EventArgs e)
        {
            lblTimeStarted.Text = DateTime.Now.ToLongTimeString();
            dtPickStart.Format = DateTimePickerFormat.Custom;
            dtPickStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtPickEnd.Format = DateTimePickerFormat.Custom;
            dtPickEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }

        private void btnCalculateTime_Click(object sender, EventArgs e)
        {
            lblTimeElapsed.Text = timeModel.subtractTime(dtPickEnd.Value, dtPickStart.Value);
        }

        private void programTimer_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToLongTimeString();
        }
    }
}