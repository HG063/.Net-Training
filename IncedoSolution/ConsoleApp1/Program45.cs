using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Hello from constructor");
            Console.WriteLine("This method will be invoked while object creation");
            Console.WriteLine();
        }
    }
    class Program45
    {
        static void Main(string[] args)
        {
            MyClass o1 = new MyClass();
            MyClass o2 = new MyClass();
        }
    }
}
