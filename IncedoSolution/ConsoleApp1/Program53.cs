using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program53
    {
        static void Swap1(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Swap2(ref int a, ref int b)//ref parameter
        {
            //Simple parameter are the copy of calling func argument, changes made in defination will not effect original
            //Ref parameter will not  create copy and update the original
            int c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before Swap : a={a}, b={b}");
            Swap1(a, b);
            Console.WriteLine($"After Swap : a={a}. b={b}");
            Swap2(ref a, ref b);
            Console.WriteLine($"After Swap using ref parameter: a={a}. b={b}");
        }
    }
}
