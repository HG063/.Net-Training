using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program66
    {
        static void Main(string[] args)
        {
            EmpModel e1 = new EmpModel { Id = 1001, EName = "Harshit", Job = "Developer", Salary = 5500 };
            EmpModel e2 = new EmpModel { Id = 1002, EName = "Booby", Job = "Trainer", Salary = 2500 };
            EmpModel e3 = new EmpModel { Id = 1003, EName = "Cathe", Job = "Programmer", Salary = 3500 };

            Console.WriteLine($"{e1.Id} {e1.EName} {e1.Job} {e1.Salary}");
            Console.WriteLine($"{e2.Id} {e2.EName} {e2.Job} {e2.Salary}");
            Console.WriteLine($"{e3.Id} {e3.EName} {e3.Job} {e3.Salary}");

        }
    }
}
