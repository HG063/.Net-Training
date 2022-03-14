using System;

namespace ConsoleApp1
{
    class Program13
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
                Console.WriteLine("Good Morning!");
            else if (hour < 16)
                Console.WriteLine("Good Afternoon!");
            else
                Console.WriteLine("Good Evening!");
        }
    }
}
