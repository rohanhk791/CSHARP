using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class nullabl
    {
        public static void Main()
        {
            int? id = null;
            Nullable<float> balance = null;
            double? intrest = null;
            string? address = null;
            string? name = null;

            Console.WriteLine("nullables\n");
            Console.WriteLine("id: {0}", id);
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("address: {0}", address);
            Console.WriteLine("balance: {0}", balance);
            Console.WriteLine("intrest earn : {0}", intrest);


            // declaring a variable for coalescing usage

            int ID = 1;
            string NAME = "rohan";
            string ADDRESS = "mandya";
            float BALANCE = 1000.1f;
            double INTREST = 1500;

            id = id ?? ID;
                name = name ?? NAME;
            address = address ?? ADDRESS;
            balance = balance ?? BALANCE;
            intrest = intrest ?? INTREST;

            Console.WriteLine("id : {0}", id);
            Console.WriteLine("name : {0}", name);
            Console.WriteLine("address : {0}", address);
            Console.WriteLine("balance : {0}", balance);
            Console.WriteLine("intrest earn : {0}", intrest);






        }

    }
}
