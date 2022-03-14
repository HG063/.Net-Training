using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program39
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the range for Fibonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 1;
            if (n == 1)
                Console.Write($"{a}, ");
            else if (n == 2)
                Console.Write($"{b}, ");
            else
            {
                Console.Write($"{a}, {b}, ");
                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write($"{c}, ");
                    a = b;
                    b = c;
                    c = a + b;
                }
            }  
        }
    }
}
