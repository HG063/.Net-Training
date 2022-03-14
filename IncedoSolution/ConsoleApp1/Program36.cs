using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program36
    {
        static void Main(string[] args)
        {
            SortedList items = new SortedList();

            items.Add("egg fry", 50);
            items.Add("choclate", 25);
            items.Add("donut", 50);
            items.Add("french fries", 60);
            items.Add("apple juice", 20);
            items.Add("biscuit", 20);

            foreach (DictionaryEntry item in items)
                Console.WriteLine($"Key = {item.Key} , Value = {item.Value}");
        }
    }
}
