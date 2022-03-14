using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program70
    {
        static void Main(string[] args)
        {
            EmpBO context = new EmpBO();
            //List<EmpModel> employees = context.employees;
            //List<EmpModel> employees = context.employees.Take(4).ToList();
            //List<EmpModel> employees = context.employees.Skip(4).ToList();
            List<EmpModel> employees = context.employees.Skip(2).Take(4).ToList();

            foreach (EmpModel e in employees)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
        }
    }
}
