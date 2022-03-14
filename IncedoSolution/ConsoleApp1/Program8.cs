using System;

namespace ConsoleApp1
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if(marks>=0&&marks<=100)
                Console.WriteLine("Marks are valid");
            else
                Console.WriteLine("Marks are not valid");
        }
    }
}
