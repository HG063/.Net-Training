using System;

namespace ConsoleApp1
{
    class Program11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Weekday Number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch(n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Weekday Input");
                    break;
            }
        }
    }
}
