using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program42
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number to Reverse : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            int t = n;
            while(n!=0)
            {
                r = r * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Reverse of {t} is : {r}");
        }
    }
}
