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

            var delims = new List<string>();
            string numbers;

            if (str[0] == '/' && str[1] == '/')
            {
                int indN = str.IndexOf('\n');
                if ((str[2] == '[') && str[indN - 1] == ']')
                {
                    int indB;
                    int start = 3;
                    do
                    {
                        indB = str.IndexOf(']', start);
                        delims.Add(str.Substring(start, indB - start));
                        start = indB + 2;
                    }
                    while (start < indN);
                    
                }
                else
                {
                    delims.Add(str.Substring(2, 1));
                }
                numbers = str.Substring(indN + 1);
            }
            else
            {
                delims.Add(",");
                delims.Add("\n");
                numbers = str;
            }

            string[] args = numbers.Split(delims.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            string negatives = "";
            for (int i = 0; i < args.Count(); i++)
            {
                int number = int.Parse(args[i]);
                if (number < 0)
                    negatives += " " + number.ToString();
                else 
                    if (number <= 1000)
                        sum += number;
            }

            if (!String.IsNullOrWhiteSpace(negatives))
                throw new Exception("negatives not allowed:" + negatives);
            return sum.ToString();

        }
    }
}
