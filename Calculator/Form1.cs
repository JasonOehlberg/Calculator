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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // *** ON FORM LOAD METHOD ***
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Converter Calculator";
            this.ShowIcon = false;
            this.MinimizeBox = true;
            // decimal default is implemented at start
            hideButtons(getNumberButtons(), 10);
            // the event listers for the input buttons are added
            addButtonListeners(getNumberButtons());
        }

        // *** METHODS FOR LABELS ***

        private Label[] getLabels()
        {
            Label[] labels = { lblBIN, lblOCT, lblDEC, lblHEX };
            return labels;
        }

        // all the labels in the array are cleared for next conversion
        private void ClearLabels()
        {
            //Label[] labels = getLabels();
            foreach (Label l in getLabels())
            {
                l.Text = "";
            }
            lblInput.Text = "";
        }

        // *** METHODS FOR BUTTONS ***

        // creates a Button array for the input buttons
        private Button [] getNumberButtons()
        {
            // these input button are the only buttons allowed for input at this time
            // without input from key input checking is not needed
            Button[] btns = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnA, btnB, btnC, btnD, btnE, btnF };
            return btns;
        }

        // makes all Buttons visible again
        private void showButtons(Button[] b)
        {
            foreach (Button btn in b)
            {
                btn.Visible = true;
            }
        }

        // adds on Click listener to each button in the input button array
        private void addButtonListeners(Button[] btns)
        {
            foreach(Button b in btns)
            {
                b.Click += Button_Click;
            }
        }

        // hides the buttons based on the active radio button
        // this limits the users input selection to those needed to make the proper conversion
        private void hideButtons(Button[] b, int firstBtn = 0)
        {
            for (int i = firstBtn; i < b.Length; i++)
            {
                b[i].Visible = false;
            }
        }

        // method for removing the last digit on the input text
        // NEEDS WORK -- NOT FINISHED
        private void backSpace()
        {
            lblInput.Text = lblInput.Text.Remove(lblInput.Text.Length - 1);
        }


        // EventListener handling Clicks for the Button array
        private void Button_Click(object sender, EventArgs e)
        {
            // grabs the text property of the button clicked
            String b = ((Button)sender).Text;

            // adds the text property off the button to the Input label
            lblInput.Text += b;

            // creates an instance of the Operation class
            Operation op = new Operation();

            // whenever any of the input buttons are clicked it evaluates the radio button checked
            // next, it converts to all the different numeric types
            // for ease of code each numeric type is converted into decimal and back into each individual type
            if (radBinary.Checked)
            {
                lblDEC.Text = op.convertToDecimal(lblInput.Text, 2);
                lblOCT.Text = op.convertFromDecimal(8, op.convertToDecimal(lblInput.Text, 2));
                lblHEX.Text = op.convertFromDecimal(16, op.convertToDecimal(lblInput.Text, 2));
                lblBIN.Text = lblInput.Text;
            }
            else if (radDecimal.Checked)
            {
                lblBIN.Text = op.convertFromDecimal(2, lblInput.Text);
                lblHEX.Text = op.convertFromDecimal(16, lblInput.Text);
                lblOCT.Text = op.convertFromDecimal(8, lblInput.Text);
                lblDEC.Text = lblInput.Text;
            }
            else if (radOctal.Checked)
            {
                lblDEC.Text = op.convertToDecimal(lblInput.Text, 8);
                lblOCT.Text = lblInput.Text;
                lblHEX.Text = op.convertFromDecimal(16, op.convertToDecimal(lblInput.Text, 8));
                lblBIN.Text = op.convertFromDecimal(2, op.convertToDecimal(lblInput.Text, 8));
            }
            else if (radHex.Checked)
            {
                lblDEC.Text = op.convertToDecimal(lblInput.Text, 16);
                lblBIN.Text = op.convertFromDecimal(2, op.convertToDecimal(lblInput.Text, 16));
                lblOCT.Text = op.convertFromDecimal(8, op.convertToDecimal(lblInput.Text, 16)); ;
                lblHEX.Text = lblInput.Text;
            }
        }    

        // Method for the Clear Button
        // clears all labels and resets to the default values
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLabels();
            radDecimal.Checked = true;
            showButtons(getNumberButtons());
            hideButtons(getNumberButtons(), 10);
        }


        // *** METHODS FOR RADIO BUTTON CHANGES ***

       // --- NEEDS REFACTORING -----

        // on selection of each radio button the labels are cleared
        // all the buttons are made visible
        // the appropriate buttons in the input button array are hidden

        private void radBinary_CheckedChanged(object sender, EventArgs e)
        {
            ClearLabels();
            showButtons(getNumberButtons());
            hideButtons(getNumberButtons(), 2);
        }

        private void radOctal_CheckedChanged(object sender, EventArgs e)
        {
            ClearLabels();
            showButtons(getNumberButtons());
            hideButtons(getNumberButtons(), 8);
        }

        private void radHex_CheckedChanged(object sender, EventArgs e)
        {
            showButtons(getNumberButtons());
            ClearLabels();
        }

        private void radDecimal_CheckedChanged(object sender, EventArgs e)
        {
            ClearLabels();
            showButtons(getNumberButtons());
            hideButtons(getNumberButtons(), 10);
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uSCustomaryUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementConverter mc = new MeasurementConverter();
            mc.Show();
            this.Hide();
        }
    }   
}

