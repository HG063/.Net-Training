using System;

namespace ConsoleApp1
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Given no is {n}");
            Console.WriteLine($"Next of {n} is {n + 1}");
            Console.WriteLine($"Square of {n} is {n * n}");
        }
    }
}
