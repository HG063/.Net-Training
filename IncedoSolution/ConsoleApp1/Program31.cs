using System;

namespace ConsoleApp1
{
    class Program31    
    {
        static void Main(string[] args)
        {
            object v1 = 100;        //boxing
            Console.WriteLine($"v1 = {v1}, data type is {v1.GetType()}");

            int n = (int)v1;    //unboxing

            v1 = "Harshit Gupta";
            Console.WriteLine($"v1 = {v1}, data type is {v1.GetType()}");

            v1 = 234.45;
            Console.WriteLine($"v1 = {v1}, data type is {v1.GetType()}");

            v1 = true;
            Console.WriteLine($"v1 = {v1}, data type is {v1.GetType()}");


        }

    }
}
