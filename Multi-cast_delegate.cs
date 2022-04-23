using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace MulticastDelegate
    {
        public delegate void MathDelegate(int No1, int No2);
        public class Program
        {
            public static void Add(int x, int y)
            {
                Console.WriteLine("The sum is : " + (x + y));
            }
            public static void Sub(int x, int y)
            {
                Console.WriteLine("The sub is : " + (x - y));
            }
            public void Mul(int x, int y)
            {
                Console.WriteLine("The mul is : " + (x * y));
            }
            public void Div(int x, int y)
            {
                Console.WriteLine("The div is : " + (x / y));
            }

            static void Main(string[] args)
            {
                Program p = new Program();
                MathDelegate del1 = new MathDelegate(Add);
                MathDelegate del2 = new MathDelegate(Program.Sub);
                MathDelegate del3 = p.Mul;
                MathDelegate del4 = new MathDelegate(p.Div); 
                MathDelegate del5 = del1 + del2 + del3 + del4;
                del5.Invoke(20, 5);
                Console.WriteLine();
                del5 -= del2;
                del5(22, 7);

                Console.ReadKey();
            }
        }
    }
