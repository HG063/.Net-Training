using System;
using System.Collections;
namespace ConsoleApp1
{
    class Program28    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            //Default Capacity is zero.
            Console.WriteLine($"Capacity is {arr.Capacity} and Count is {arr.Count}");

            //While adding 1st element capacity increases to 4. like if int it increases to 4 bytes
            //and in double it increases to 8 bytes.
            //Operations - Add(), Remove(), TrimToSize(), Sort(), Reverse() etc.
            arr.Add(100);
            Console.WriteLine($"Capacity is {arr.Capacity} and Count is {arr.Count}");
        }
        
    }
}
