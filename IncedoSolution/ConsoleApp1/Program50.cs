using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass1
    {
        public static void Display()
        {
            Console.WriteLine("Hello from MyClass1 Display");
        }
    }
    class Program50
    {
        public static void Display()
        {
            Console.WriteLine("Hello from Display");
        }
        
        static void Main(string[] args)
        {
            MyClass1.Display();
            Display();
        }
    }
}
