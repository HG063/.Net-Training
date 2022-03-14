using System;

namespace ConsoleApp1
{
    class Program21    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Elements : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Print Array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }

        }

    }
}
