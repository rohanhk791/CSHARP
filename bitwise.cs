using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitwise
{
    internal class BitwiseOperators
    {
        public static void Main()
        {
            int num1 = 20;
            int num2 = 15;
            int num3;

            //Bitwise OR
            num3 = num1 | num2;
            Console.WriteLine(num3);


            //Bitwise AND
            num3 = num1 & num2;
            Console.WriteLine(num3);


            //Bitwise XOR
            num3 = num1 ^ num2;
            Console.WriteLine(num3);


            //Bitwise complement
            int num4 = 60; //0011 1100
            Console.WriteLine(~num4); // Tildde


            //Bitwise Left Shift 
            int left = 42;
            Console.WriteLine(left << 1);
            Console.WriteLine(left << 4);


            //Bitwise Right Shift 
            Console.WriteLine(left >> 1);
            Console.WriteLine(left >> 2);
            Console.WriteLine(left >> 3);
            Console.WriteLine(left >> 4);

            Console.ReadLine();

        }
    }
}
