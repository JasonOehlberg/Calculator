using System;
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
            addButtonListeners(getNumberButtons());
            addRadMeasureTypeListeners(getMeasurementRadBtn());
            addRadConvertListeners(getConvertToRadBtn());
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

        private void addRadMeasureTypeListeners(RadioButton[] rads)
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
            if (((RadioButton)sender).Text.Equals("US Standard"))
            {
                if (radDistance.Checked)
                {
                    cbUnitType.Items.Clear();

                    foreach (string item in mc.getMetricList("Distance"))
                        cbUnitType.Items.Add(item);
                    cbUnitType.SelectedIndex = 0;
                }
                else if (radVolume.Checked)
                {
                    cbUnitType.Items.Clear();

                    foreach (string item in mc.getMetricList("Volume"))
                        cbUnitType.Items.Add(item);
                    cbUnitType.SelectedIndex = 0;
                }
                else if (radWeight.Checked)
                {
                    cbUnitType.Items.Clear();

                    foreach (string item in mc.getMetricList("Weight"))
                        cbUnitType.Items.Add(item);
                    cbUnitType.SelectedIndex = 0;
                }
            }
            else if(((RadioButton)sender).Text.Equals("Metric")){
                if (radDistance.Checked)
                {
                    cbUnitType.Items.Clear();

                    foreach (string item in mc.getUSList("Distance"))
                        cbUnitType.Items.Add(item);
                    cbUnitType.SelectedIndex = 0;
                }
                else if (radVolume.Checked)
                {
                    cbUnitType.Items.Clear();

                    foreach (string item in mc.getUSList("Volume"))
                        cbUnitType.Items.Add(item);
                    cbUnitType.SelectedIndex = 0;
                }
                else if (radWeight.Checked)
                {
                    cbUnitType.Items.Clear();

                    foreach (string item in mc.getUSList("Weight"))
                        cbUnitType.Items.Add(item);
                    cbUnitType.SelectedIndex = 0;
                }
            }
        }

        private void RadioMeasure_CheckedChanged(Object sender, EventArgs e)
        {
            
            cbUnitType.Items.Clear();
            string id = ((RadioButton)sender).Text;
            if (radMetric.Checked)
            {

                foreach (string item in mc.getUSList(id))
                {
                    cbUnitType.Items.Add(item);
                }
                cbUnitType.SelectedIndex = 0;

            }
            if (radUS.Checked)
            {
               
                foreach (string item in mc.getUSList(id))
                {
                    cbUnitType.Items.Add(item);
                }
                cbUnitType.SelectedIndex = 0;
            }
        }

    }
}
