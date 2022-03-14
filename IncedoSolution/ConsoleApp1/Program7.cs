using System;

namespace ConsoleApp1
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n==0)
                Console.WriteLine("Input is Zero");
            else if(n>0)
                Console.WriteLine($"{n} is Positive");
            else
                Console.WriteLine($"{n} is Negative");
        }
    }
}
