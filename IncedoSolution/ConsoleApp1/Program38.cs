using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program38
    {
        static void Main(string[] args)
        {
            //Exception Handling
            int? n = null;
            Console.Write("Enter an Integer : ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Input is not an Integer Type Value, Setting Input value to 0");
                n = 0;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Input value is not in range, Setting Input value to 1");
                n = 1;
            }
            finally
            {
                Console.WriteLine($"Square of {n} is {n*n}");
            }
        }
    }
}
