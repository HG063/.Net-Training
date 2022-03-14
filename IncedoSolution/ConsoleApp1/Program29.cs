using System;
using System.Collections;
namespace ConsoleApp1
{
    class Program29    
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(100);
            arr.Add(200);
            arr.Add(300);
            arr.Add(400);
            arr.Add(500);

            Console.WriteLine("Elements before Sort : ");
            foreach(int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();
            
            arr.Sort();
            Console.WriteLine("Elements after Sort : ");
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();
            
            arr.Reverse();
            Console.WriteLine("Elements after Reverse : ");
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();

            arr.Remove(400);
            Console.WriteLine("Element 400 removed : ");
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        
    }
}
