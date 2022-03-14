using System;

namespace ConsoleApp1
{
    class Program25    {
        static void Main(string[] args)
        {
            int[,] arr = { { 2, 3, 4, 5 }, { 6, 7, 8, 9 } };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{arr[i, j]} ");
                Console.WriteLine();
            }

        }
        
    }
}
