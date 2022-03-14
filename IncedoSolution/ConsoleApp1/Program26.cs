using System;

namespace ConsoleApp1
{
    class Program26   {
        static void Main(string[] args)
        {
            int[][] arr = new int[5][];//Jagged Array
            arr[0] = new int[] { 10, 20, 30, 40, 50, 60 };
            arr[1] = new int[] { 11, 12, 13, 14};
            arr[2] = new int[] { 100,200,300};
            arr[3] = new int[] { 1,2,3,4,5};
            arr[4] = new int[] { 1000 };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write($"{arr[i][j]} ");
                Console.WriteLine();
            }
        }
        
    }
}
