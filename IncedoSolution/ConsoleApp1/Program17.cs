using System;

namespace ConsoleApp1
{
    class Program17    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to Generate Multiplication Table :- ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            Console.WriteLine($"{n} x {i} = {n*i}");
           }
        
    }
}
