using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program54
    {
        static void Initialize(out int a)//out parameter
        {
            a = 0;
        }
        static void Main(string[] args)
        {
            int a;
            Initialize(out a);
            Console.WriteLine($"a = {a}");
        }
    }
}
