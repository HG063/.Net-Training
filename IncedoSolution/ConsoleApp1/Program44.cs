using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Numbers
    {
        private int num1, num2;

        public void SetNumbers(int n1, int n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public void GetNumbers()
        {
            Console.WriteLine($"Number 1 : {this.num1}, Number 2 : {this.num2}");
        }
    }
    class Program44
    {
        static void Main(string[] args)
        {
            Numbers n1 = new Numbers();
            Numbers n2 = new Numbers();
            n1.SetNumbers(100, 200);
            n2.SetNumbers(10, 20);
            n1.GetNumbers();
            n2.GetNumbers();
        }
    }
}
