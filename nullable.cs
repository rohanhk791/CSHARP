using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Show the working of Nullables with various datatype.
//Show the working of NULL COALESCING OPERATOR ??

namespace nullable
{
    public class Nullables
    {
        public static void Main()
        {

            //Declaring Nullables on various Datatypes
            int? id = null;
            Nullable<float> balance = null;
            double? intrest = null;
            string? address = null;
            string? name = null;

            //Printing the Nullable Values
            Console.WriteLine("Nullables\n");
            Console.WriteLine("book ID        : {0}", id);
            Console.WriteLine("authorname       : {0}", name);
            Console.WriteLine("Address         : {0}", address);
            Console.WriteLine("Balance Amt    : {0}", balance);
            Console.WriteLine("Intrest earn : {0}", intrest);

            //Declaring variables for Coalescing usage
            int ID = 1;
            float BALANCE = 10000.10f;
            double INTREST = 1400.00;
            string ADDRESS = "Mandya";
            string NAME = "Rohan H K";

            //Coalescing the nullable values
            id = id ?? ID;
            name = name ?? NAME;
            address = address ?? ADDRESS;
            balance = balance ?? BALANCE;
            intrest = intrest ?? INTREST;

            //Printing the updated value here
            Console.WriteLine("\n\nCoalescing the Null values\n");

            Console.WriteLine("User ID        : {0}", id);
            Console.WriteLine("Username       : {0}", name);
            Console.WriteLine("Address        : {0}", address);
            Console.WriteLine("Balance Amt    : {0}", balance);
            Console.WriteLine("Intrest earn   : {0}", intrest);



        }
    }
}