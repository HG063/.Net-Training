using System;

namespace ConsoleApp1
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Last Month Reading : ");
            int lmr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Present Month Reading : ");
            int pmr = Convert.ToInt32(Console.ReadLine());

            int bu = pmr - lmr;
            double amt = 0.0;

            if (bu < 100)
                amt = bu * 1.25;
            else if (bu >= 100 && bu <= 250)
                amt = bu * 2.75;
            else if (bu >= 251 && bu <= 400)
                amt = bu * 3.50;
            else if (bu >= 401 && bu <= 500)
                amt = bu * 4;
            else 
                amt = bu * 6;

            Console.WriteLine($"Current Bill Amount : {amt}");

        }
    }
}
