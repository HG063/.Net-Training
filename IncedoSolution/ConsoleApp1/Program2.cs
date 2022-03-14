using System;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            string name = "Harshit Gupta";
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"Length of {name} is {name.Length}");

            Console.WriteLine($"UPPER CASE OF {name} IS {name.ToUpper()}");
            Console.WriteLine($"lower case of {name} is {name.ToLower()}");
        }
    }
}
