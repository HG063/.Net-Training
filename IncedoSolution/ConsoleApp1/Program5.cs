using System;

namespace ConsoleApp1
{
    class Program5
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Add of {a} and {b} is {a + b}");
            Console.WriteLine($"Sub of {a} and {b} is {a - b}");
            Console.WriteLine($"Mult of {a} and {b} is {a * b}");
            Console.WriteLine($"Div of {a} and {b} is {a / b}");
        }
    }
}
