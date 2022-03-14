using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program56
    {
        static void Addition(params int[] items)// params take any number of parameters
        {
            int sum = 0;
            for (int i = 0; i < items.Length; i++)
                sum = sum + items[i];
            Console.WriteLine($"Sum of Items: {sum}");
        }
        static void Students(params string[] names)//param parameter
        {
            Console.Write("Names of Students : ");
            for(int i=0;i<names.Length;i++)
                Console.Write($"{names[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Addition(10,20);
            Addition(100, 200, 300);
            Addition(11, 22, 33, 44);
            Students("Ram", "Shyam", "Geeta", "Sita");
            Students("Raj", "Ravi");
        }
    }
}
