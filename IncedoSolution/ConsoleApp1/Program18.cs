using System;

namespace ConsoleApp1
{
    class Program18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating Alphabets from A to Z :- ");
            for (int i = 65; i <= 90; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
            Console.WriteLine();
            Console.WriteLine("Generating Alphabets from Z to A :- ");
            for (int i = 90; i >= 65; i--)
            {
                Console.Write($"{(char)(i)} ");
            }
            Console.WriteLine();
            Console.WriteLine("Generating Alphabets from a to z :- ");
            for (int i = 97; i <= 122; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
            Console.WriteLine();
            Console.WriteLine("Generating Alphabets from z to a :- ");
            for (int i = 122; i >= 97; i--)
            {
                Console.Write($"{(char)(i)} ");
            }
            Console.WriteLine();
            Console.WriteLine("Generating Alphabets from 0 to 9 :- ");
            for (int i = 48; i <= 57; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
            Console.WriteLine();
        }
    }
}
