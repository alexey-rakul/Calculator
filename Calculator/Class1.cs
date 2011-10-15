using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calculator1
    {
        public static string Add(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return "0";
            char[] delims;
            string numbers;
            if (str[0] == '/' && str[1] == '/' && str[3] == '\n')
            {
                delims = new char[] { str[2] };
                numbers = str.Substring(4);
            }
            else
            {
                delims = new char[] { ',', '\n' };
                numbers = str;
            }
            string[] args = numbers.Split(delims);
            if (args.Length == 1)
                return args[0];
            else
            {
                int sum = 0;
                for (int i = 0; i < args.Count(); i++)
                    sum += int.Parse(args[i]);
                  
                return sum.ToString();
            }
        }
    }
}
