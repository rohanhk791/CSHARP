using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class _2
    {

        public static void Main()
        {
            int a=2, b=4; 
            Console.WriteLine("Before swap a= " + a + " b= " +b);
            a = a * b; 
            b = a / b; 
            a = a / b; 
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }

    }
