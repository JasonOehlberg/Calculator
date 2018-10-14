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
    public partial class MeasurementConverter : Form
    {
        private MeasurementCalc mc;
        public MeasurementConverter()
        {
            InitializeComponent();
            mc = new MeasurementCalc();
            mc.DecimalPressed = false;
           
        }

        private void MeasurementConverter_Load(object sender, EventArgs e)
        {
            this.Text = "Measurement Converter";
            this.ShowIcon = false;
            lblInput.Text = "0";
        }

        private Button[] getNumberButtons()
        {
            // these input button are the only buttons allowed for input at this time
            // without input from key input checking is not needed
            Button[] btns = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            return btns;
        }

        private RadioButton[] getConvertToRadBtn()
        {
            RadioButton[] rads = { radMetric, radUS };
            return rads;
        }

        private RadioButton[] getMeasurementRadBtn()
        {
            RadioButton[] rads = { radDistance, radVolume, radWeight };
            return rads;
        }

        private void addRadConvertListeners(RadioButton[] rads)
        {
            foreach (RadioButton r in rads)
                r.CheckedChanged += RadioConvert_CheckedChanged;
        }

        private void addRadMeasurTypeListeners(RadioButton[] rads)
        {
            foreach (RadioButton r in rads)
                r.CheckedChanged += RadioMeasure_CheckedChanged;
        }

        private void addButtonListeners(Button[] btns)
        {
            foreach (Button b in btns)
            {
                b.Click += Button_Click;
            }
        }

        private void Button_Click(Object sender, EventArgs e)
        {
            
            if (lblInput.Text.Equals("0"))
            {
                lblInput.Text = "";
                lblInput.Text = ((Button)sender).Text;
            }
            else
            {
                
                lblInput.Text += ((Button)sender).Text;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (lblInput.Text.Equals("0"))
            {
                return;
            }
            else
            {
                string removeTemp = lblInput.Text.Remove(lblInput.Text.Length - 1, 1);
                lblInput.Text = removeTemp;
                if (lblInput.Text.Equals(""))
                {
                    lblInput.Text = "0";
                }
            }

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (lblInput.Text.Equals("0") && mc.DecimalPressed == false) // l***********ook at logic
            {
                lblInput.Text = "0.";
            }
            else if (mc.DecimalPressed)
            {
                return;
            }
            else
            {
                lblInput.Text += ((Button)sender).Text;
            }
            mc.DecimalPressed = true;
        }

        private void RadioConvert_CheckedChanged(Object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text.Equals("Metric"))
            {
                Debug.WriteLine("Im in Metric");
                if (radDistance.Checked)
                {
                    cbUnitType.Items.Clear();

                    foreach (string item in mc.metricDistance)
                        cbUnitType.Items.Add(item);
                    cbUnitType.SelectedIndex = 0;
                }
                else if (radVolume.Checked)
                {
                    
                }
                else if (radWeight.Checked)
                {

                }
            }
        }

        private void RadioMeasure_CheckedChanged(Object sender, EventArgs e)
        {

        }

    }
}
