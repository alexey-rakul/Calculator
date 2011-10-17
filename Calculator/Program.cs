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
            Console.WriteLine("Testing 0 args...");
            if (Calculator1.Add("") == "0")
                Console.WriteLine("OK!");
            else
                Console.WriteLine("NOT OK!");
        }

        static void TestOneArgs()
        {
            Console.WriteLine("Testing 1 args...");
            if (Calculator1.Add("1") == "1")
                Console.WriteLine("OK!");
            else
                Console.WriteLine("NOT OK!");
        }

        static void TestTwoArgs()
        {
            Console.WriteLine("Testing 2 args...");
            if (Calculator1.Add("2,2") == "4")
                Console.WriteLine("OK!");
            else
                Console.WriteLine("NOT OK!");
        }

        static void TestUnknownArgs()
        {
            Console.WriteLine("Testing unknown args...");
            if (Calculator1.Add("2,2,3") == "7")
                Console.WriteLine("OK!");
            else
                Console.WriteLine("NOT OK!");
        }

        static void TestNewLineDelim()
        {
            Console.WriteLine("Testing '\\n' as delimiter...");
            if (Calculator1.Add("1,2\n3") == "6")
                Console.WriteLine("OK!");
            else
                Console.WriteLine("NOT OK!");
        }

        static void TestUserDelim()
        {
            Console.WriteLine("Testing user delimiter...");
            if (Calculator1.Add("//;\n1;2") == "3")
                Console.WriteLine("OK!");
            else
                Console.WriteLine("NOT OK!");
        }

        static void TestNegatives()
        {
            Console.WriteLine("Testing negatives...");
            if (Calculator1.Add("//;\n-1;2;-3;4;-5;6") == "3")
                Console.WriteLine("OK!");
            else
                Console.WriteLine("NOT OK!");
        }

        static void Main(string[] args)
        {
            try
            {
                TestZeroArgs();
                TestOneArgs();
                TestTwoArgs();
                TestUnknownArgs();
                TestNewLineDelim();
                TestUserDelim();
                TestNegatives();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
