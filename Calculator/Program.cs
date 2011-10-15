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

        static void TestUnknownArgs()
        {
            if (Calculator1.Add("2,2,3") == "7")
                Console.WriteLine("Testing unknown args...OK!");
            else
                Console.WriteLine("Testing unknown args...NOT OK!");
        }

        static void TestNewLineDelim()
        {
            if (Calculator1.Add("1,2\n3") == "6")
                Console.WriteLine("Testing '\\n' as delimiter...OK!");
            else
                Console.WriteLine("Testing '\\n' as delimiter...NOT OK!");
        }

        static void TestUserDelim()
        {
            if (Calculator1.Add("//;\n1;2") == "3")
                Console.WriteLine("Testing user delimiter...OK!");
            else
                Console.WriteLine("Testing user delimiter...NOT OK!");
        }

        static void Main(string[] args)
        {
            TestZeroArgs();
            TestOneArgs();
            TestTwoArgs();
            TestUnknownArgs();
            TestNewLineDelim();
            TestUserDelim();
        }
    }
}
