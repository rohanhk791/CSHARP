using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplecatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,x;
            Console.WriteLine("enter two number");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("c value = " + c);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("second number should not be zero");
                Console.Write("Do you wanna stay in Generic Calculator [Y/N] : ");
                x = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("enter only integer numbers");
                Console.Write("Do you wanna stay in Generic Calculator [Y/N] : ");
                x = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}