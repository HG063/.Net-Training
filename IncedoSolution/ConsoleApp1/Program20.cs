using System;

namespace ConsoleApp1
{
    class Program20   
    {
        static void Main(string[] args)
        {
            int[] arr = {10,20,30,40,50};
            Console.WriteLine("Printing Array : ");
            for(int i=0; i<arr.Length; i++)
                Console.WriteLine($"arr[{i}] : {arr[i]}");
        }
        
    }
}
