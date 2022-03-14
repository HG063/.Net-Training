using System;

namespace ConsoleApp1
{
    class Program27    {
        static void Main(string[] args)
        {
            string[][] arr = new string[5][];
            arr[0] = new string[] {"a","b","c","d"};
            arr[1] = new string[] { "x", "y", "z" };
            arr[2] = new string[] { "l", "m", "n", "o", "p" };
            arr[3] = new string[] { "abc", "xyz", "uvw" };
            arr[4] = new string[] { "abcdefgh" };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write($"{arr[i][j]} ");
                Console.WriteLine();
            }

        }
        
    }
}
