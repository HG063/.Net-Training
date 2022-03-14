using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program40
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number for factorial : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
                f = f * i;
            Console.WriteLine($"Factorial of a {n} is : {f}");
        }
    }
}
