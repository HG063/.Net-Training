using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program69
    {
        static void Main(string[] args)
        {
            EmpBO context = new EmpBO();
            foreach (EmpModel e in context.employees)
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
        }
    }
}
