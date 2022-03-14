using System;

namespace ConsoleApp1
{
    class Program6
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a letter: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Given letter is {ch}");

            Console.WriteLine($"Next letter of {ch} is {(char)(ch + 1)}");
            Console.WriteLine($"Previous letter of {ch} is {(char)(ch - 1)}");
        }
    }
}
