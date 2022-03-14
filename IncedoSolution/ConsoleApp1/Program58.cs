using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee    //Parent Class
    {
        //public int empno;
        protected string category, cycle;
        protected double holidays;
        public Employee() // Constructor
        {
            category = "Employee ";
            cycle = "daily";
            holidays = 1;
        }

        public void MyCompanyInfo()
        {
            Console.WriteLine("Kiran Software Solutions\nEstd 2005");
        }

        public void MyFacilities()
        {
            Console.WriteLine($"Category : {category}");
            Console.WriteLine($"Salary Billing calculations : {cycle}");
            Console.WriteLine($"Number of holidays per month : {holidays}");
        }
    }
    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee() // Constructor
        {
            category = "Regular Employee and Full Time";
            cycle = "Monthly";
            holidays = 2.5;
        }
    }
    class PartTimeEmployee : Employee
    {
        public PartTimeEmployee() // Constructor
        {
            category = "Free Lancer => Part Time Employee";
            cycle = "Hourly";
            holidays = 1.25;
        }
    }

    class Program58
    {
        static void Main(string[] args)
        {
            FullTimeEmployee f1 = new FullTimeEmployee();
            f1.MyFacilities();

            PartTimeEmployee p1 = new PartTimeEmployee();
            p1.MyFacilities();

            //Console.ReadKey();
        }
    }
}
