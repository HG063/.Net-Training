using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class NumCon
        {
        private int num;
        public NumCon()
        {
            this.num = 0;
        }
        public NumCon(int n)
        {
            this.num = n;
        }
        public void SetNumber(int n)
        {
            this.num = n;
        }
        public void GetNumber()
        {
            Console.WriteLine($"Number : {this.num}");
        }
        }
    class Program46
    {
        static void Main(string[] args)
        {
            NumCon n1 = new NumCon();
            n1.GetNumber();

            NumCon n2 = new NumCon(100);
            n2.GetNumber();

            NumCon n3 = new NumCon();
            n3.SetNumber(10);
            n3.GetNumber();
        }
    }
}
