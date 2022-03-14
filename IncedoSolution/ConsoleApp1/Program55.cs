using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program55
    {
        static void SetRole(string qly, out string jobrole)//out parameter
        {
            switch (qly)
            {
                case "B.Tech":
                    jobrole = "Programmer";
                    break;
                case "MCA":
                    jobrole = "Developer";
                    break;
                case "MBA":
                    jobrole = "HR";
                    break;
                default:
                    jobrole = "Assistant";
                    break;
            }
        }
        static void Main(string[] args)
        {
            string qly = "B.Tech";
            string jobrole;
            SetRole(qly, out jobrole);
            Console.WriteLine($"Qualification : {qly}, Jobrole : {jobrole}");
        }
    }
}
