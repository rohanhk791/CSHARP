using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class dispose_method : IDisposable
    {


        public void Dispose()
        {
            Console.WriteLine("this is dispose method()");
        }


    }
    class sub
    {
        public sub()
        {
            int a = 10, b = 5, c = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, c);

        }
        ~sub()
        {
            Console.WriteLine("Im destructor");
        }


    }
    class demo
    {
        public static void Main()
        {
            sub a = new sub();
            dispose_method d = new dispose_method();
            d.Dispose();

        }
    }
}