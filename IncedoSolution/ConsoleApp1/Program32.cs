using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program32   
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(100);
            arr.Add("abc");
            arr.Add(7.54);
            arr.Add(true);
            arr.Add('a');

            foreach(var i in arr)
                Console.WriteLine($"{i} ");

        }
        
    }
}
