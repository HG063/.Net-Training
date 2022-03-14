using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumsCon
    {
        private int num1, num2;
        public NumsCon()
        {
            this.num1 = 0;
            this.num2 = 0;
        }
        public NumsCon(int n1, int n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
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
    class Program47
    {
        static void Main(string[] args)
        {
            NumsCon k1 = new NumsCon();
            NumsCon k2 = new NumsCon(11,22);
            k1.GetNumbers();
            k2.GetNumbers();
            NumsCon n1 = new NumsCon();
            NumsCon n2 = new NumsCon();
            n1.SetNumbers(100, 200);
            n2.SetNumbers(10, 20);
            n1.GetNumbers();
            n2.GetNumbers();
        }
    }
}
