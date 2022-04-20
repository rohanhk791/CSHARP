﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    internal class Nullables
    {
        public static void Main()
        {
            int num1 = 20; //SYNTAX FOR NULLABLE
            int? num2 = null;  //NULLABLE GENERIC 

            Nullable<int> num3 = null;
            Console.WriteLine("Num1 is:{0}", num1);
            Console.WriteLine("Null Values are:{0} and {1}", num2, num3);

            //NULL COALESCING OPERATOR ??
            int? a = null;
            int? b = 10;
            int? c;
            c = a ?? b;

            Console.WriteLine("C is:{0}", c);
            c = a ?? 200;
            Console.WriteLine("C is:{0}", c);
        }
    }
}
