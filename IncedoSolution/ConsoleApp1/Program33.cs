using System;
using System.Collections;
namespace ConsoleApp1
{
    class Program33    
    {
        static void Main(string[] args)
        {
            Hashtable items = new Hashtable();
            // before "," is keys and after "," is values  - (keys,values)

            items.Add("biscuit", 20);
            items.Add("choclate", 25);
            items.Add("donut", 50);

            Console.WriteLine("What are keys in hash table lets check : ");
            foreach(var i in items.Keys)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("What are values in hash table lets check : ");
            foreach (var i in items.Values)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{items["biscuit"].ToString()}");
            Console.WriteLine($"{items["choclate"].ToString()}");
            Console.WriteLine($"{items["donut"].ToString()}");



        }

    }
}
