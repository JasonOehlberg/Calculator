/*
 Jason Oehlberg
 CS.4253 Windows Programming
 Homework 2: Conversion Calculator
 Due: 2018.09.25
 */

using System;
using System.Diagnostics;
using System.Linq;

namespace Calculator
{

    class Operation
    {

        // string conversion to unsigned long
        // Becuase negative numbers are not being evaluated, unsigned integers are used
        // this will allow for larger positive numbers to be converted
        public UInt64 stringToNumber(string s)
        {
            string temp = s;
            UInt64 num = Convert.ToUInt64(temp);
            
            return num;
        }

        // *** CONVERSIONS FROM DECIMAL ***

        // method converts from decimal to all other numeric types
        // method takes the base of the type and the string from the input label as parameters
        public string convertFromDecimal(UInt16 BASE, string number)
        {
            UInt64 num = stringToNumber(number);
            String result = "";

            while (num >= 1)
            {
                // Because hexidecimal uses letters for values, a special case must be checked -- (BASE == 16)
                if(BASE == 16)
                {
                    // outputs the string into the proper format for hex
                    result = result + (num % BASE).ToString("X");
                }
                else
                {
                    // otherwise it evaluates as normal
                    result = result + (num % BASE);
                }
                
                num /= BASE;
            }

            // reverses the string to display correctly
            result = new String(result.Reverse().ToArray());
            return result;
        }

            // NEEDS WORK
            // eventually this will add the leading zeros to the binary number and separate tuples
            public string leadingZeros(string s)
        {
            int strLength = s.Length % 4;
            while (strLength > 0)
            {
                s = s + "0";
                strLength--;
            }

            return s;
        }

        // *** CONVERSION to DECIMAL ***

        // method takes a string from the input label and the BASE of the numeric type as parameters
        public string convertToDecimal(string number, UInt16 BASE)
        {
            // keeps track of the exponent from largest to 0
            int exponent = number.Length - 1;
            // keeps the running total -- unsigned integer is used to allow for larger positive numbers, negatives are not evaluated
            UInt64 total = 0;

            // foreach loop evaluates each character in the string
            foreach(char num in number)
            {
                // temp is here to hold the ASCII value of a letter if it should appear
                int temp = 0;
                // total adds the BASE raised to the power of the exponent times the reult of the turnary statement
                // TURNARY: if the character num is a letter then (ASCII) 55 is subtracted from it and multiplied with left half of the equation
                // else num must be a number value and its converted and multiplied with the left half of the equation
                total += ((UInt64)Math.Pow(BASE, exponent) * (Char.IsLetter(num) ? (Convert.ToUInt16(temp = num - 55)) : (UInt16)Char.GetNumericValue(num)));
                exponent--;
            }
            
            // the decimal number is converted to a string
            return total.ToString();
        }
        
    }
}
