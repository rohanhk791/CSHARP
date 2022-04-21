using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inter
{
    internal class area_per
    {
        interface area
        {
            double res(int w, int h);

        }
        interface perimeter
        {
            int res2(int a, int b, int c);
        }
        class Calculation : area, perimeter
        {
            public double result1;
            public double res(int w, int h)
            {
                return result1 = 0.5 * w * h;
            }
            public int result2;
            public int res2(int a, int b, int c)
            {
                return result2 = a + b + c;
            }
            internal class Program
            {
                static void Main()
                {
                    Calculation c = new Calculation();
                    c.res(6, 2);
                    c.res2(10, 12, 25);
                    Console.WriteLine("Area of triangle is " + c.result1);
                    Console.WriteLine("Perimeter of triangle is " + c.result2);
                }
            }
        }
    }
}