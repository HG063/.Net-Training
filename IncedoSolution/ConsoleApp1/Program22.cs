using System;

namespace ConsoleApp1
{
    class Program22   {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Elements : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int big = 0, small = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
                if (i == 0) { big = small = arr[0]; }
                else if (arr[i] > big)
                    big = arr[i];
                else if (arr[i] < small)
                    small = arr[i];

            }
            Console.WriteLine("Print Array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine($"Sum of Elements : {sum}");
            Console.WriteLine($"Average of Elements : {sum/n}");
            Console.WriteLine($"Count of Elements : {arr.Length}");
            Console.WriteLine($"Biggest Element in an Array : {big}");
            Console.WriteLine($"Smallest Element in an Array : {small}");
        }
        
    }
}
