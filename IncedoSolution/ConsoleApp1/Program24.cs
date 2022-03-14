using System;

namespace ConsoleApp1
{
    class Program24   {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];

            arr[0, 0] = 100;
            arr[0, 1] = 200;
            arr[1, 0] = 300;
            arr[1, 1] = 400;

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                    Console.WriteLine($"{arr[i,j]}");
            }
        }
        
    }
}
