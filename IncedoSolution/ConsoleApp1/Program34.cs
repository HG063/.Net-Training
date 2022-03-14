using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program34
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Srinivas");
            ht.Add(102, "Sindhura");
            ht.Add(103, "Kiran");
            ht.Add(104, "Ravi");
            ht.Add(105, "Srilatha");

            foreach (int key in ht.Keys)
                Console.WriteLine(key.ToString());

            foreach (string value in ht.Values)
                Console.WriteLine(value);
        }
    }
}
