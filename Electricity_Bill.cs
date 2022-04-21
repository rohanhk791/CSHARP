using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bill
{
    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();
        public void calculation(int units)
        {
            Console.Write("bill amount for " + units + " unit is: Rs.");
            Console.WriteLine(rate * units);
        }
    }
    class VillagePlan : Plan
    {
        public override void getRate()
        {
            rate = 5.00;
        }
    }
    class CityPlan : Plan
    {
        public override void getRate()
        {
            rate = 7.50;
        }
    }
    internal class Abstraction
    {
        static void Main()
        {
            Plan p;
            Console.WriteLine("village connection");
            p = new VillagePlan();
            p.getRate();
            p.calculation(100);
            Console.WriteLine("city connection");
            p = new CityPlan();
            p.getRate();
            p.calculation(150);
            Console.ReadKey();
        }
    }
}

