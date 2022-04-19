using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class sum
    {
        public void natural()
        {

            int n = 0, sum = 0, count = 0;


            Console.Write("Enter the Range for natural numbers: 1 to ");
            n = Convert.ToInt32(Console.ReadLine());
            n = n + 1;


            while (count != n)
            {

                sum += count;

                count++;

            }

            Console.WriteLine("the Sum of natural numbers is : {0}", sum);
        }

        //main method
        public static void Main()
        {

            sum s = new sum();
            s.natural();
        }
    }
}