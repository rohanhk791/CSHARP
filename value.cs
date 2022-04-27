using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class passbyvalue
    {
        public static void Main()
        {
            Console.WriteLine("this is a pass by value");
            int X = 100;
            Console.WriteLine("Variable value before calling the method: " + X);
            AddingNumberByFive(X);
            Console.WriteLine("Variable value after calling the method: " + X);
            Console.WriteLine("enter to exit");
            Console.ReadLine();
       
        Console.WriteLine("this is a pass by reference");
            int value = 100;
        Console.WriteLine("Variable value before calling the method: " + value);
            AddingNumberByFive(ref value);
        Console.WriteLine("Variable value after calling the method: " + value);
            Console.WriteLine("enter to exit");
            Console.ReadLine();
            
        public static void AddingNumberByFive(int number)
        {
            number = number + 5;
            Console.WriteLine("Variable value inside the method : " + number);
        }

        {
            Console.WriteLine("this is a pass by reference");
            int value = 100;
            Console.WriteLine("Variable value before calling the method: " + value);
            AddingNumberByFive(ref value);
            Console.WriteLine("Variable value after calling the method: " + value);
            Console.WriteLine("enter to exit");
            Console.ReadLine();
        }
        public static void AddingNumberByFive(ref int value)
        {
            value = value + value;
            Console.WriteLine("Variable value inside the method : " + value);
        }

    }
}
