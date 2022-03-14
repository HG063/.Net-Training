using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program51
    {
        public static void Display()//unparameterized
        {
            Console.WriteLine("Hello From Display");
        }
        public static void Wishes(string str)//parameterized
        {
            Console.WriteLine($"Hello {str}");
        }
        static void Main(string[] args)
        {
            Display();
            Wishes("Harshit");
        }
    }
}
