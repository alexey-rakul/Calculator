﻿using System;
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
            char[] delims = new char[] {',' };
            string[] args = str.Split(delims);
            if (args.Count() == 1)
                return args[0];
            else
            {
                int sum = int.Parse(args[0]) + int.Parse(args[1]);
                return sum.ToString();
            }
        }
    }
}
