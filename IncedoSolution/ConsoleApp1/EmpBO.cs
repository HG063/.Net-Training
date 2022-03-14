//Program - 69,70
using System.Collections.Generic;

namespace ConsoleApp1
{
    class EmpBO
    {
        public List<EmpModel> employees;
        public EmpBO()
        {
            employees = new List<EmpModel>()
            {
            new EmpModel { Id = 1001, EName = "Harshit", Job = "Developer", Salary = 5500 },
            new EmpModel { Id = 1002, EName = "Booby", Job = "Trainer", Salary = 2500 },
            new EmpModel { Id = 1003, EName = "Cathe", Job = "Programmer", Salary = 3500 },
            new EmpModel { Id = 1004, EName = "Bobby", Job = "Developer", Salary = 2900 },
            new EmpModel { Id = 1005, EName = "Chandu", Job = "Trainer", Salary = 2100 }
            };
        }

    }
}
