using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program68
    {
        static void Main(string[] args)
        {
            List<EmpModel> employees = new List<EmpModel>()
            {
            new EmpModel{ Id = 1001, EName = "Harshit", Job = "Developer", Salary = 5500},
            new EmpModel { Id = 1002, EName = "Booby", Job = "Trainer", Salary = 2500 }
            };

            employees.Add(new EmpModel { Id = 1003, EName = "Cathe", Job = "Programmer", Salary = 3500 });
            employees.Add(new EmpModel { Id = 1004, EName = "Bobby", Job = "Developer", Salary = 2900 });
            employees.Add(new EmpModel { Id = 1005, EName = "Chandu", Job = "Trainer", Salary = 2100 });

            foreach (EmpModel e in employees)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
        }
    }
}
