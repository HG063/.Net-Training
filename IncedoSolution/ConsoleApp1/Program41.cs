using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program41
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it is prime or not : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 2)
                Console.WriteLine($"{n} is a Prime Number");
            else
                Console.WriteLine($"{n} is not a Prime Number");
            
        }
    }
}
