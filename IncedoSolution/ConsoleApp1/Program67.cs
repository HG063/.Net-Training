using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program67
    {
        static void Main(string[] args)
        {
            EmpModel e1 = new EmpModel { Id = 1001, EName = "Harshit", Job = "Developer", Salary = 5500 };
            EmpModel e2 = new EmpModel { Id = 1002, EName = "Booby", Job = "Trainer", Salary = 2500 };
            EmpModel e3 = new EmpModel { Id = 1003, EName = "Cathe", Job = "Programmer", Salary = 3500 };

            List<EmpModel> employees = new List<EmpModel>();
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);

            foreach(EmpModel e in employees)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");

        }
    }
}
