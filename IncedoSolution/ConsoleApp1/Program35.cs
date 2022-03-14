using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program35
    {
        static void Main(string[] args)
        {
            Hashtable items = new Hashtable();

            items.Add("biscuit", 20);
            items.Add("choclate", 25);
            items.Add("donut", 50);

            foreach (DictionaryEntry i in items)
                Console.WriteLine($"Key = {items.Keys} , Values = {items.Values}");
        }
    }
}
