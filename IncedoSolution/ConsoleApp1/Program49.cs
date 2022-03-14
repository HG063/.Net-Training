using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private string gender;
        private string age;
        public Person(string name, string gender, string age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{this.name} {this.gender} {this.age}");
        }
    }
    class Program49
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Harshit","Male","23");
            Person p2 = new Person("Pulkit","Male","24");
            p1.GetDetails();
            p2.GetDetails();

        }
    }
}
