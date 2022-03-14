using System;

namespace ConsoleApp1
{
    class Program9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Name of Student : ");
            string name = Console.ReadLine();
            Console.Write("Enter Physics Marks : ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry Marks : ");
            int chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Maths Marks : ");
            int math = Convert.ToInt32(Console.ReadLine());
            
            int sum = phy + chem + math;
            double avg = sum / 3.0;
            
            Console.WriteLine($"Total Marks of {name} : {sum}");
            Console.WriteLine($"Average Marks of {name} : {avg}");

            string result = "";
            string grade = "";

            if(phy>=32 && chem>=32 && math>=32)
            {
                result = "Pass";
                if (avg >= 90)
                    grade = "A";
                else if (avg >= 80)
                    grade = "B";
                else if (avg >= 70)
                    grade = "c";
                else
                    grade = "D";
            }
            else
            {
                result = "Fail";
                grade = "F";
            }

            Console.WriteLine($"The Result of Student is : {result} and Grade is : {grade}");

        }
    }
}
