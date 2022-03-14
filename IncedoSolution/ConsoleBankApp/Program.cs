using System;
using System.Collections;

namespace ConsoleBankApp
{
    class BankAccount
    {
        private int id;
        private string cname;
        private double accountBalance;
        public BankAccount()
        {
            this.id = 0;
            this.cname = "";
            this.accountBalance = 0.0;
        }
        public BankAccount(int id,string name,double amount)
        {
            this.id = id;
            this.cname = name;
            this.accountBalance = amount;
        }
        
        public double Deposit(double amount)
        {
            Console.WriteLine($"Id of the Customer : {id}");
            Console.WriteLine($"Name of the Customer : {cname}");
            return this.accountBalance = this.accountBalance + amount;
        }
        public double Withdraw(double amount)
        {
            Console.WriteLine($"Id of the Customer : {id}");
            Console.WriteLine($"Name of the Customer : {cname}");
            return this.accountBalance = this.accountBalance - amount;
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Bank Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Amount Balance : ");
            double balance = Convert.ToDouble(Console.ReadLine());
            BankAccount ba = new BankAccount(id,name,balance);
            Console.WriteLine();
            Console.WriteLine("Enter 1 to deposit in Bank Account");
            Console.WriteLine("Enter 2 to withdraw from Bank Account");
            Console.Write("Enter your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if ((DateTime.Now.DayOfWeek == DayOfWeek.Monday && (DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)) || (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday && (DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)) || (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday && (DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)) || (DateTime.Now.DayOfWeek == DayOfWeek.Thursday && (DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)) || (DateTime.Now.DayOfWeek == DayOfWeek.Friday && (DateTime.Now.Hour >= 9 && DateTime.Now.Hour <= 18)))
            {
                if (choice == 1)
                {
                    Console.Write("Enter Amount to Deposit : ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Amount After Deposit : {ba.Deposit(amount)}");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Amount to Withdraw : ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (balance < amount)
                        Console.WriteLine($"Insufficient Balance, {amount} cannot be Withdrawn!");
                    else
                    {
                        Console.WriteLine($"{amount} Withdrawn Successful...");
                        Console.WriteLine($"Amount Balance After Withdraw : {ba.Withdraw(amount)}");
                    }
                }
            }
            else
            Console.WriteLine("Bank is Closed Now!, Come in Working Hours.");
        } 
    }
}
