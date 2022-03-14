using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program37
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);
            Console.WriteLine("Integer List : ");
            foreach(int i in list)
                Console.Write($"{i} ");
            Console.WriteLine();
            

            List<string> str_list = new List<string>() {"ABC", "EFG", "XYZ"};
            str_list.Add("ABCDE");
            str_list.Add("PQRST");
            Console.WriteLine("String List");
            foreach(string i in str_list)
                Console.Write($"{i} ");
        }
    }
}
