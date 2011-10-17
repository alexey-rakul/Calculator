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
            int sum = 0;
            string negatives = "";
            for (int i = 0; i < args.Count(); i++)
            {
                int number = int.Parse(args[i]);
                if (number < 0)
                    negatives += " " + number.ToString();
                else
                    sum += number;
            }

            if (!String.IsNullOrWhiteSpace(negatives))
                throw new Exception("negatives not allowed:" + negatives);
            return sum.ToString();

        }
    }
}
