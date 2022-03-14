using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Number
    {
        private int num; //private data number

        public void SetNumber(int n) //public method
        {
            this.num = n; //Data Member accessible with prefix with this keyword
        }
        public void GetNumber() //public method
        {
            Console.WriteLine($"Num = {this.num}");
        }
    }
    class Program43
    {
        static void Main(string[] args)
        {
            Number n1 = new Number();
            n1.SetNumber(100);
            n1.GetNumber();

            Number n2 = new Number();
            n2.SetNumber(200);
            n2.GetNumber();
        }
    }
}
