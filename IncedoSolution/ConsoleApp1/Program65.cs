using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Poco Class
    class UserModel
    {
        public string Uname { get; set; }
        public string Password { get; set; }
    }
    class Program65
    {
        static void Main(string[] args)
        {
            UserModel u1 = new UserModel { Uname = "user1", Password = "pwd1" };
            UserModel u2 = new UserModel { Uname = "user2", Password = "pwd2" };
            Console.WriteLine($"Uname = {u1.Uname}, Pwd = {u1.Password}");
            Console.WriteLine($"Uname = {u2.Uname}, Pwd = {u2.Password}");
        }
    }
}
