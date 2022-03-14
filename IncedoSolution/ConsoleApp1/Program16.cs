using System;

namespace ConsoleApp1
{
    class Program16    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number for sum of digits :- ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(n!=0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Sum of digits : {sum}");
           }
        
    }
}
