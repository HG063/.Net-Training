using System;

namespace ConsoleApp1
{
    class Program15
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Generate Numbers from 1 to 10 using for loop :- ");
            for(i=1;i<=10;i++)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.Write("Generate Numbers from 1 to 10 using for while loop :- ");
            i = 1;
            while(i<=10)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine();
            Console.Write("Generate Numbers from 1 to 10 using for do while loop :- ");
            i = 1;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <= 10);
        }
        
    }
}
