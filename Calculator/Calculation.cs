using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculation : Operation 
    {
        public Double Total { get; set; }
        public String Operator { get; set; }
        public bool OperatorPressed { get; set; }
        public bool DecimalPressed { get; set; }

        public string evaluateEquation(string equation)
        {
            Debug.WriteLine("evaluation method");
            string[] temp = equation.Split(' ');
            foreach (string t in temp)
                Debug.WriteLine(t);
            string total = "";
            if (temp[1].Equals("+"))
                total = (Convert.ToDouble(temp[0]) + Convert.ToDouble(temp[2])).ToString();
            else if (temp[1].Equals("-"))
            {
                total = (Convert.ToDouble(temp[0]) - Convert.ToDouble(temp[2])).ToString();
                Debug.WriteLine(total);
            }
                
            else if (temp[1].Equals("÷"))
            {
                if (temp[2].Equals("0"))
                {
                    return "Can't ÷ by 0";
                }
                total = (Convert.ToDouble(temp[0]) / Convert.ToDouble(temp[2])).ToString();
            }
                
            else if (temp[1].Equals("×"))
                total = (Convert.ToDouble(temp[0]) * Convert.ToDouble(temp[2])).ToString();
            Debug.WriteLine(total);
            return total;
        }

        public string negate(string s)
        {
            double number = Convert.ToDouble(s);
            number *= -1;
            return number.ToString();
        }
    }
}
