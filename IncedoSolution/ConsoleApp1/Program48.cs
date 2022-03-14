using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        private string name;
        private string address;
        private string phonenumber;

        public Customer()
        {
            this.name = "Name not Provided";
            this.address = "Address not Provided";
            this.phonenumber = "Phone Number not Provided";
        }
        public Customer(string name, string address, string phonenumber)
        {
            this.name = name;
            this.address = address;
            this.phonenumber = phonenumber;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Name of Customer : {this.name}");
            Console.WriteLine($"Address of Customer : {this.address}");
            Console.WriteLine($"Phone Number of Customer : {this.phonenumber}");
            Console.WriteLine();
        }
    }
    class Program48
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer("Harshit Gupta","Lucknow","7388226762");
            c1.GetDetails();
            c2.GetDetails();
        }
    }
}
