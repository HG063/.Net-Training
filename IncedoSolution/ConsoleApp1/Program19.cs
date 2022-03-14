using System;

namespace ConsoleApp1
{
    class Program19    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Numbers in an array : ");
            int[] arr = new int[5];
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
            arr[3] = 400;
            arr[4] = 500;
            Console.WriteLine("Printing Array");
            Console.WriteLine($"{arr[0]}");
            Console.WriteLine($"{arr[1]}");
            Console.WriteLine($"{arr[2]}");
            Console.WriteLine($"{arr[3]}");
            Console.WriteLine($"{arr[4]}");
        }
    }
}
