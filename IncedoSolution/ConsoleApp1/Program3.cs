using System;

namespace ConsoleApp1
{
    class Program3
    {
        static void Main(string[] args)
        {
            string v1 = "Harshit Gupta";
            Console.WriteLine($"value is {v1}, data type is {v1.GetType()}");

            int v2 = 100;
            Console.WriteLine($"value is {v2}, data type is {v2.GetType()}");

            bool v3 = true;
            Console.WriteLine($"value is {v3}, data type is {v3.GetType()}");

            double v4 = 45.56;
            Console.WriteLine($"value is {v4}, data type is {v4.GetType()}");
        }
    }
}
