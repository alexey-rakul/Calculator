using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace TestCalculator
{
    class Program
    {
        static void TestZeroArgs()
        {
            if (Calculator1.Add("") == "0")
                Console.WriteLine("Testing 0 args...OK!");
            else
                Console.WriteLine("Testing 0 args...NOT OK!");
        }

        static void TestOneArgs()
        {
            if (Calculator1.Add("1") == "1")
                Console.WriteLine("Testing 1 args...OK!");
            else
                Console.WriteLine("Testing 1 args...NOT OK!");
        }

        static void TestTwoArgs()
        {
            if (Calculator1.Add("2,2") == "4")
                Console.WriteLine("Testing 2 args...OK!");
            else
                Console.WriteLine("Testing 2 args...NOT OK!");
        }

        static void Main(string[] args)
        {
            TestZeroArgs();
            TestOneArgs();
            TestTwoArgs();
        }
    }
}
