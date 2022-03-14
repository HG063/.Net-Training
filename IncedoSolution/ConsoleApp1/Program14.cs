using System;

namespace ConsoleApp1
{
    class Program14
    {
            enum MaritalStatus
        {
            Married, UnMarried, Divorce
        }
        static void Main(string[] args)
        {
            MaritalStatus m1 = MaritalStatus.UnMarried;
            switch (m1)
            {
                case MaritalStatus.Married:
                    Console.WriteLine("You can leave at 6pm daily");
                    break;
                case MaritalStatus.UnMarried:
                    Console.WriteLine("You have to say till 7pm");
                    break;
                case MaritalStatus.Divorce:
                    Console.WriteLine("You can WFH");
                    break;
            }
        }
        
    }
}
