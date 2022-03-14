using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class BaseClass
	{
		private int dm1 = 100;      //Availble within existing class
		protected int dm2 = 200;        //Availble within and derived class
		public int dm3 = 300;        //Availble everywhere
		public void DisplayBase()
		{
			Console.WriteLine($"dm1 = {dm1}, dm2 = {dm2}, dm3 = {dm3}");
		}
	}
	class DerivedClass : BaseClass
	{
		public void DisplayDerived()
		{
			//Console.WriteLine($"dm1 = {dm1}");	//error
			Console.WriteLine($"From Derived class : dm2(Protected Member) = {dm2}, dm3(Public Member) = {dm3}");
		}
	}

	class Program57
    {
        static void Main(string[] args)
        {
			DerivedClass o = new DerivedClass();
			o.DisplayDerived();
			Console.WriteLine($"From main class : Public Member : {o.dm3}");
		}
	}
}
