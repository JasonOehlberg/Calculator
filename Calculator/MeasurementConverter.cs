/*
 Author: Jason Oehlberg
 Program: Calculator
 Date: 2018.10.31
 */

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
            // Create a MeasurementCalc Model to Form
            mc = new MeasurementCalc();
            // Set default DecimalPressed value
            mc.DecimalPressed = false;
            // Initialize Number Button Listeners
            addButtonListeners(getNumberButtons());
            // Initialize Measurement RadioButton Listeners
            addRadMeasureTypeListeners(getMeasurementRadBtn());
            // Initialize Conversion RadioButton Listeners
            addRadConvertListeners(getConvertToRadBtn());
            this.KeyPreview = true;
        }

        private void MeasurementConverter_Load(object sender, EventArgs e)
        {
            // set Title of Form
            this.Text = "Measurement Converter";
            // set Icon not to show
            this.ShowIcon = false;
            // set lblInput to default value
            lblInput.Text = "0";
        }

        private Button[] getNumberButtons()
        {
            // these input button are the only buttons allowed for input at this time
            // without input from key input checking is not needed
            Button[] btns = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            return btns;
        }

        // grabs all the Conversion RadioButtons
        private RadioButton[] getConvertToRadBtn()
        {
            RadioButton[] rads = { radMetric, radUS };
            return rads;
        }

        // grabs all the Measurment RadioButtons
        private RadioButton[] getMeasurementRadBtn()
        {
            RadioButton[] rads = { radDistance, radVolume, radWeight };
            return rads;
        }

        // Adds EventListeners to all Conversion RadioButtons
        private void addRadConvertListeners(RadioButton[] rads)
        {
            foreach (RadioButton r in rads)
                r.CheckedChanged += RadioConvert_CheckedChanged;
        }

        // Adds EventListeners to all Measurement RadioButtons
        private void addRadMeasureTypeListeners(RadioButton[] rads)
        {
            foreach (RadioButton r in rads)
                r.CheckedChanged += RadioMeasure_CheckedChanged;
        }

        // Adds EventListeners to all Number Buttons
        private void addButtonListeners(Button[] btns)
        {
            foreach (Button b in btns)
            {
                b.Click += Button_Click;
            }
        }

        // Actions to follow when Number Button is Clicked
        private void Button_Click(Object sender, EventArgs e)
        {
            // If the lblInput is still at default value
            if (lblInput.Text.Equals("0"))
            {
                // Clear Text
                lblInput.Text = "";
                // Register Button
                lblInput.Text = ((Button)sender).Text;
            }
            else
            {
                // Resgister Button when not at default value
                lblInput.Text += ((Button)sender).Text;
            }
        }

        // Actions for Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Set lblInput back to default
            lblInput.Text = "0";
            // Set all result Labels back to default
            lblDataLarge.Text = "";
            lblDataMiddle.Text = "";
            lblDataSmall.Text = "";
            mc.DecimalPressed = false;
        }

        // Actions for the BackSpace Button
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            // If lblInput at default does nothing
            if (lblInput.Text.Equals("0"))
            {
                return;
            }
            else
            {
                // Removes the last item from the lblInput string array
                string removeTemp = lblInput.Text.Remove(lblInput.Text.Length - 1, 1);
                lblInput.Text = removeTemp;
                // Resets the default when array is empty
                if (lblInput.Text.Equals(""))
                {
                    lblInput.Text = "0";
                }
            }
        }

        // Actions when Decimal Button is Clicked
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Action if lblInput is at default value
            if (lblInput.Text.Equals("0") && mc.DecimalPressed == false)
            {
                lblInput.Text = "0.";
            }
            // Action if the DecimalPress property has been previously pressed and is set to true
            else if (mc.DecimalPressed)
            {
                return;
            }
            else
            // Action if DecimalPress is False
            {
                // Decimal Added to string array
                lblInput.Text += ((Button)sender).Text;
            }
            // Sets the DecimalPressed to be evaluated when Button pressed Again
            mc.DecimalPressed = true;
        }

        // Get the ArrayList of strings for the appropriate conversion type
        private ArrayList getListType(string name, string id)
        {
            // If Convert to US Standard RadioButton Checked
            if (name.Equals("US Standard"))
            {
                return mc.getMetricList(id);
            }
            // else Convert to Metric RadioButton Checked
            else
                return mc.getUSList(id);
        }

        // Populates ComboBox cbUnitType if conditions are met -- Conversion Radio Buttons
        private void RadioConvert_CheckedChanged(Object sender, EventArgs e)
        {
            // Find which Conversion RadioButton is Checked
            foreach(RadioButton rbConvert in getConvertToRadBtn())
            {
                if (((RadioButton)sender).Text.Equals(rbConvert.Text))
                {
                    // Find which RadioButton Checked
                    foreach (RadioButton rbMeasure in getMeasurementRadBtn())
                    {
                        if (rbMeasure.Checked)
                        { 
                            // Clears the Combo Box
                            cbUnitType.Items.Clear();
                            // Populates Combo Box with the list of strings
                            foreach (string item in getListType(rbConvert.Text, rbMeasure.Text))
                            {
                                cbUnitType.Items.Add(item);
                            }
                            // Defaults the selection to the first string
                            cbUnitType.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        // Populates ComboBox cbUnitType if conditions are met -- Measurement Radio Buttons
        private void RadioMeasure_CheckedChanged(Object sender, EventArgs e)
        { 

            // Find which Measurement RadioButton Checked
            foreach(RadioButton rbMeasure in getMeasurementRadBtn())
            {
                if (((RadioButton)sender).Text.Equals(rbMeasure.Text))
                {
                    // Find which Conversion Button is Checked
                    foreach (RadioButton rbConvert in getConvertToRadBtn())
                    {
                        if (rbConvert.Checked)
                        {
                            // Clears ComboBox
                            cbUnitType.Items.Clear();
                            // Gets appropriate list and populates based on the selections
                            foreach (string item in getListType(rbConvert.Text, rbMeasure.Text))
                            {
                                cbUnitType.Items.Add(item);
                            }
                            // Set default ComboBox selection to first string
                            cbUnitType.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        // Returns the UnityType array from the Dictionary in MeasurementCalc to deal with conversions - based on name = the Dictionary itself
        // and id = the Key for the UnitType array to return -- used for the conversion to the base unit and other Unit type
        private UnitType[] getUnitListType(string name, string id)
        {
            if(name.Equals("US Standard"))
            {
                return mc.getMetricUnitList(id);
            }
            else
            {
                return mc.getUSUnitList(id);
            }
        }

        // Returns the UnityType array from the Dictionary in MeasurementCalc to deal with conversions - based on name = the Dictionary itself
        // and id = the Key for the UnitType array to return -- used for conversion of the base unit to each other units
        private UnitType[] switchUnitType(string name, string id)
        {
            if(name.Equals("US Standard"))
            {
                return mc.getUSUnitList(id);
            }
            else
            {
                return mc.getMetricUnitList(id);
            }
        }

        // Actions when Calculate Button Clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Loop to find Measurement RadioButton checked
            foreach (RadioButton rb in getMeasurementRadBtn())
            {
                if (rb.Checked)
                {
                    // Loop to find Conversion RadioButton Checked
                    foreach(RadioButton rbConvert in getConvertToRadBtn())
                    {
                        if (rbConvert.Checked)
                        {
                            // Temporary variable to hold a converted value -- CAN REMOVE
                            string convertedValue = "";
                            //Loop through appropriate Array based on the RadioButton Selections calling getUnitLisType method
                            for (int i = 0; i < getUnitListType(rbConvert.Text, rb.Text).Length; i++)
                            {
                               // Matching the name of UnitType with ComboBox Text
                                if (getUnitListType(rbConvert.Text, rb.Text)[i].Name.Equals(cbUnitType.Text))
                                { 
                                    // Temporary variable holding part of the function calls for the equation
                                    // First gets UnitType array then converts to base of same unit type
                                    string temp = mc.convert(lblInput.Text, getUnitListType(rbConvert.Text, rb.Text)[i].Conversion);
                                    // Converted Value holds the conversion result after converting the the other UnitType's base unit
                                    convertedValue = mc.convertToOtherFormat(temp, rb.Text, getUnitListType(rbConvert.Text, rb.Text)[i].IsMetric);    
                                }
                            }
                            // Each result Label is populated with the base converted value divided by the conversion of the opposite UnitType -- switchUnitType() or not for base unit
                            lblDataSmall.Text = (Convert.ToDouble(convertedValue) / switchUnitType(rbConvert.Text, rb.Text)[0].Conversion).ToString();
                            lblUnitTypeSmall.Text = switchUnitType(rbConvert.Text, rb.Text)[0].Name;
                            lblDataMiddle.Text = convertedValue;
                            lblUnitTypeMiddle.Text = switchUnitType(rbConvert.Text, rb.Text)[1].Name;
                            lblDataLarge.Text = (Convert.ToDouble(convertedValue) / switchUnitType(rbConvert.Text, rb.Text)[2].Conversion).ToString();
                            lblUnitTypeLarge.Text = switchUnitType(rbConvert.Text, rb.Text)[2].Name;
                        }

                    }
                   
                }
            }
           
        }

        // Opens the Standard Calculator From if the X on the window bar is clicked
    

        // All below open a new form and close the current one when clicked
        private void Calculator_Click(object sender, EventArgs e)
        {
            Hide();
            AppControl.GetForm("StandardCalculator").Show();
        }

        private void Time_Click(object sender, EventArgs e)
        {
            Hide();
            AppControl.GetForm("Time").Show();
        }

        private void Programmer_Click(object sender, EventArgs e)
        {
            Hide();
            AppControl.GetForm("ProgrammerView").Show();
        }

        private void MeasurementConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
