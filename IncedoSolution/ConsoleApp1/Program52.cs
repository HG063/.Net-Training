using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Calculations
    {
        public static int Square(int n)
        {
            return n * n;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Big(int a, int b)
        {
            return a > b ? a : b;
        }
    }
    class Program52
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square : {Calculations.Square(5)}");
            Console.WriteLine($"Add : {Calculations.Add(5,6)}");
            Console.WriteLine($"Big : {Calculations.Big(5,6)}");
        }
    }
}
