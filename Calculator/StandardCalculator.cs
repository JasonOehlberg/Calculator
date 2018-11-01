/*
 Author: Jason Oehlberg
 Program: Calculator
 Date: 2018.10.31
 */

using System;
using System.Windows.Forms;


namespace Calculator
{
    public partial class StandardCalculator : Form
    {
        // property holds wheather an operator button has been pressed
        
        // field for the Calculation object used in the Standard Calculator session
        private Calculation calc;

        public StandardCalculator()
        {
            InitializeComponent();

            // Instance of the Calculation class
            calc = new Calculation();
            // OperatorPressed property to false
            calc.OperatorPressed = false;
            calc.DecimalPressed = false;
            // Total property set to zero -- so the equation will not evaluate for the first time
            calc.Total = 0;
            calc.Operator = "";
        }

        private void StandardCalculator_Load(object sender, EventArgs e)
        {
            // Form text set
            this.Text = "Standard Calculator";
            // The default icon is hidden
            this.ShowIcon = false;
            // the EventListeners for the button groups are set
            addOperandListeners(getOperandButtons());
            addOperatorListeners(getOperatorButtons());
        }

        private Button[] getOperandButtons()
        {
            // these input button are the only buttons allowed for input at this time
            // without input from key input checking is not needed
            Button[] btns = { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            return btns;
        }

        private Button[] getOperatorButtons()
        {
            // grabs all of the operator buttons
            Button[] btns = { btnDivide, btnMultiply, btnPlus, btnSubtract, btnEquals };
            return btns;
        }

        // Adds a Click Listener to each Operand button
        private void addOperandListeners(Button[] btns)
        {
            foreach (Button b in btns)
            {
                b.Click += OperandButton_Click;
            }
        }

        // Adds a Click Listener to each Operator button
        private void addOperatorListeners(Button[] btns)
        {
            foreach (Button b in btns)
            {
                b.Click += Operator_Click;
            }
        }

        // Defines what is done when the operand button is clicked
        private void OperandButton_Click(Object sender, EventArgs e)
        {
            // If Text = 0 (start of StandardCalculator) or the Operator button is pressed then the label is nothing
            if (lblInput.Text.Equals("0") || calc.OperatorPressed == true || calc.Operator.Equals("="))
            {
                lblInput.Text = "";
                calc.OperatorPressed = false;
                lblInput.Text = ((Button)sender).Text;
            }
            else
            {
                // the operand buttons text is added to the lblInput string
                lblInput.Text += ((Button)sender).Text;
            }
            
        }

       
        // Method formats the equation string to be processed in the Calculation class
        private string formatEquation(string operand1, string operator1, string operand2)
        {
            return operand1 + " " + operator1 + " " + operand2 + " "; 
        }

        // Method handles the Operators on click
        private void Operator_Click(Object sender, EventArgs e)
        {
            // Else If an operand was pressed before this operator was pressed (!OperatorPressed)
            // temp is set to the lblInput text
            string temp = lblInput.Text;
            // If an Operator was previously pressed
            if (calc.OperatorPressed)
            {
                // Gets the index of the previous operator in the lblEquation string
                int index = lblEquation.Text.Length - 3;
                // creates a new string without the operator and the space after
                string removeTemp = lblEquation.Text.Remove(index, 2);
                // sets the lblEquation string to the new temp string and the new operator button that has just been pressed
                lblEquation.Text = removeTemp + ((Button)sender).Text + " ";
                // the Operator property is set to the current text of the button pressed
                calc.Operator = ((Button)sender).Text;
            }
            else if (((Button)sender).Text.Equals("="))
            {
                lblInput.Text = calc.evaluateEquation(formatEquation(calc.Total.ToString(), calc.Operator, temp));
                lblEquation.Text = "";
                calc.Operator = ((Button)sender).Text;
                calc.OperatorPressed = false;
                calc.Total = 0;
            }
            else
            {
                
                // If Total property does not equal zero (or the first equation)
                if (!(calc.Total == 0))
                {
                    // lblInput is set to the evaluated equation after the string is formated
                    lblInput.Text = calc.evaluateEquation(formatEquation(calc.Total.ToString(),calc.Operator, temp));
                }
                // the total is set to the lblInput text (on the first equation would be set to the unevaluated number)
                calc.Total = Convert.ToDouble(lblInput.Text);
                // lbl Equatiion text is set to the temp value stored before and the opertator button pressed
                lblEquation.Text += (temp + " " + ((Button)sender).Text + " ");
                // set to true and determines how the next button press will be handled
                calc.OperatorPressed = true;
                // the Operator property is set to the text of the current button pressed
                calc.Operator = ((Button)sender).Text;
            }
            calc.DecimalPressed = false;
        }

        // Action for C Button is Clicked
        private void btnC_Click(object sender, EventArgs e)
        {
            // everything is set back to default and cleared
            lblInput.Text = "0";
            lblEquation.Text = "";
            calc.Total = 0;
            calc.Operator = "";
            calc.OperatorPressed = false;
        }

        // Action for CE Button Clicked
        private void btnCE_Click(object sender, EventArgs e)
        {
            // only the lblInput is set back to default
            lblInput.Text = "0";
        }

        // Action when Decimal Button is Clicked
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // if the label is set to default or the equals has been pressed and DecimalPressed has not been activated
            if ((lblInput.Text.Equals("0") || calc.Operator.Equals("=")) && calc.DecimalPressed == false)
            {
                // then zero followed by decimal
                lblInput.Text = "0.";
            }
            else if (calc.DecimalPressed)
            {
                // Decimal is pressed again does nothing
                return;
            }
            else
            {
                // first time decimal has been pressed in a sequence of numbers
                lblInput.Text += ((Button)sender).Text;
            }
            calc.DecimalPressed = true;
        }

        // Actions for he +/- Button
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            // text is set to the negative of the value oft the string
            lblInput.Text = calc.negate(lblInput.Text);
        }

        // Actions for the BackSpace Button
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            // If the label is set to default
            if (lblInput.Text.Equals("0"))
            {
                return;
            }
            else
            {
                // If not at default it removes the last digit
                string removeTemp = lblInput.Text.Remove(lblInput.Text.Length - 1, 1);
                lblInput.Text = removeTemp;
                // when the string array is empty sets back to default
                if (lblInput.Text.Equals(""))
                {
                    lblInput.Text = "0";
                }
            }  
        }

        private void measurementConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AppControl.GetForm("MeasurementConverter").Show();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AppControl.GetForm("Time").Show();
        }

        private void Programmer_Click(object sender, EventArgs e)
        {
            Hide();
            AppControl.GetForm("ProgrammerView").Show();
        }

        private void StandardCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Action for the programmer Menu Item


    }
}
