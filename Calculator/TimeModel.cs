using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Calculator
{
    class TimeModel
    {
        
        public string subtractTime (DateTime time1, DateTime time2)
        {
            if(time1 > time2)
            {
                TimeSpan difference = time1.Subtract(time2);
                StringBuilder build = new StringBuilder();
                build.Append($"{difference.Days} days, ");
                build.Append($"{difference.Hours} hours,\n");
                build.Append($"{difference.Minutes} minutes, ");
                build.Append($"{difference.Seconds} seconds");
                return build.ToString();
            }
            else
            {
                return "End date must be larger than Start date.";
            }
            

            
        }
    }
}
