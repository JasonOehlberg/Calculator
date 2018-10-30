using System;
using System.Collections;
using System.Diagnostics;
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
            lblDataLarge.Text = "";
            lblDataMiddle.Text = "";
            lblDataSmall.Text = "";
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

        private ArrayList getListType(string name, string id)
        {
            if (name.Equals("US Standard"))
            {
                return mc.getMetricList(id);
            }
            else
                return mc.getUSList(id);
        }

        private void RadioConvert_CheckedChanged(Object sender, EventArgs e)
        {
            foreach(RadioButton rbConvert in getConvertToRadBtn())
            {
   
                if (((RadioButton)sender).Text.Equals(rbConvert.Text))
                {
                    foreach (RadioButton rbMeasure in getMeasurementRadBtn())
                    {
                        if (rbMeasure.Checked)
                        { 
                            cbUnitType.Items.Clear();
                            
                            foreach (string item in getListType(rbConvert.Text, rbMeasure.Text))
                            {
                                cbUnitType.Items.Add(item);
                            }
                            cbUnitType.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void RadioMeasure_CheckedChanged(Object sender, EventArgs e)
        { 
            foreach(RadioButton rbMeasure in getMeasurementRadBtn())
            {
                if (((RadioButton)sender).Text.Equals(rbMeasure.Text))
                {
                    foreach (RadioButton rbConvert in getConvertToRadBtn())
                    {
                        if (rbConvert.Checked)
                        {
                            cbUnitType.Items.Clear();
                            foreach (string item in getListType(rbConvert.Text, rbMeasure.Text))
                            {
                                cbUnitType.Items.Add(item);
                            }
                            cbUnitType.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string type = "";
            foreach (RadioButton rb in getMeasurementRadBtn())
            {
                if (rb.Checked)
                {
                    type = rb.Text;
                }
            }
            if (radUS.Checked)
            {
                Debug.WriteLine(type);
                string convertedValue = "";
               
                for (int i = 0; i < mc.getMetricUnitList(type).Length; i++)
                {
                    if (mc.getMetricUnitList(type)[i].Name.Equals(cbUnitType.Text))
                    {
                        string temp = mc.metricConvert(lblInput.Text, mc.getMetricUnitList(type)[i].Conversion);
                        convertedValue = mc.convertToOtherFormat(temp, type, mc.getMetricUnitList(type)[i].IsMetric);
                    }
                }
                lblDataSmall.Text = (Convert.ToDouble(convertedValue) / mc.getUSUnitList(type)[0].Conversion).ToString() + " " + mc.getUSUnitList(type)[0].Name;
                lblDataMiddle.Text = convertedValue + " " + mc.getUSUnitList(type)[1].Name;
                lblDataLarge.Text = (Convert.ToDouble(convertedValue) / mc.getUSUnitList(type)[2].Conversion).ToString() + " " + mc.getUSUnitList(type)[2].Name;
            }
            else if (radMetric.Checked)
            {
                string convertedValue = "";
                
                for (int i = 0; i < mc.getUSUnitList(type).Length; i++)
                {
                    if (mc.getUSUnitList(type)[i].Name.Equals(cbUnitType.Text))
                    {
                        string temp = mc.usConvert(lblInput.Text, mc.getUSUnitList(type)[i].Conversion);
                        convertedValue = mc.convertToOtherFormat(temp, type, mc.getUSUnitList(type)[i].IsMetric);
                    }
                }
                Debug.WriteLine("Converted Value: " + convertedValue);
                lblDataSmall.Text = (Convert.ToDouble(convertedValue) / mc.getMetricUnitList(type)[0].Conversion).ToString() + " " + mc.getMetricUnitList(type)[0].Name; 
                lblDataMiddle.Text = convertedValue + " " + mc.getMetricUnitList(type)[1].Name;
                lblDataLarge.Text = (Convert.ToDouble(convertedValue) / mc.getMetricUnitList(type)[2].Conversion).ToString() + " " + mc.getMetricUnitList(type)[1].Name; 
            }
        }
            
    }
}
