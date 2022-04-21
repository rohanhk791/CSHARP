using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hybrid
{

	class GrandFather
	{

		public void land()
		{
			Console.WriteLine("GrandFather");
		}

	}

	class Father : GrandFather
	{

		public void home()
		{
			Console.WriteLine("Father home");
		}

		public void Car()
		{
			Console.WriteLine("Father Car");
		}
	}

	// Inherit /derived / extends
	class Son : Father
	{

		// son constructor
		public Son()
		{
			Console.WriteLine("Son.........");
		}

		public void bike()
		{
			Console.WriteLine("Son bike");
		}
	}

	class Daughter : Father
	{

		// Daughter constructor
		public Daughter()
		{
			Console.WriteLine("Daughter..........");
		}

		public void scooty()
		{
			Console.WriteLine("Daughter's scooty");
		}
	}

	public class HybridInheritance
	{

		public static void Main(String[] args)
		{

			// Son object
			Son s = new Son();
			s.land();// Grand father method
			s.Car(); // Father method
			s.home();// Father method
			s.bike();// son method

			// Daughter object
			Daughter d = new Daughter();
			d.land();// Grand father method
			d.Car(); // Father method
			d.home();// Father method
			d.scooty();//  Daughter method

		}

	}

	internal class hybrid_inheritance
	{
	}
}
