using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class cal
    {
        public static void Main()
        {
            int ro;
            char x = 'y';
            int a = 0, b = 0;
            double e = 0, d = 0;

            gencalc<int> cal = new gencalc<int>();
            gencalc<double> cal2 = new gencalc<double>();
            Console.WriteLine("Generic Calculator");


            while (x == 'y' || x == 'Y')

            {
                Console.WriteLine("\n1:ADDITION\t 2:SUBTRACTION\t 3:MULTIPLICATION\t 4:DIVISION\t 5:PERCENTAGE\n");
                ro = Convert.ToInt32(Console.ReadLine());
                switch (ro)

                {
                    //Case 1 performs Addition operation of int type
                    case 1:
                        Console.Write("Enter 1st number........   : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter 2nd number....... : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        int sum = cal.Addition(a, b);
                        Console.WriteLine("Addition :{0}", sum);
                        Console.Write("Do you wanna stay in Generic Calculator [Y/N] : ");
                        x = Convert.ToChar(Console.ReadLine());
                        break;

                    //Case 2 performs Subtraction operation of int type
                    case 2:
                        Console.Write("Enter 1st number   : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter 2nd number : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        int val = cal.Subtraction(a, b);
                        Console.WriteLine("\nSubtraction :{0}", val);
                        Console.Write("Do you wanna stay in Generic Calculator [Y/N] : ");
                        x = Convert.ToChar(Console.ReadLine());
                        break;

                    //Case 3 performs Multiplication operation on int type
                    case 3:
                        Console.Write("Enter 1st number   : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter 2nd number : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        int mux = cal.Mutliplication(a, b);
                        Console.WriteLine("\nMultiplication :{0}", mux);
                        Console.Write("Do you wanna stay in Generic Calculator [Y/N] : ");
                        x = Convert.ToChar(Console.ReadLine());
                        break;

                    //Case 4 performs Division operation
                    case 4:
                        Console.Write("Enter 1st number   : ");
                        d = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter 2nd number : ");
                        e = Convert.ToDouble(Console.ReadLine());
                        double div = cal2.Division(d, e);
                        Console.WriteLine("\nDivision :{0}", div);
                        Console.Write("Do you wanna stay in Generic Calculator [Y/N] : ");
                        x = Convert.ToChar(Console.ReadLine());
                        break;

                    //Case 5 performs percentage operation
                    case 5:

                        Console.Write("Enter Obtained Marks   : ");
                        d = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter Total Marks : ");
                        e = Convert.ToDouble(Console.ReadLine());
                        double per = cal2.Percentage(d, e);
                        Console.WriteLine("\nPercentage :{0}", per);
                        Console.Write("Do you wanna stay in Generic Calculator[Y/N] : ");
                        x = Convert.ToChar(Console.ReadLine());
                        break;

                    //Default state
                    default:
                        Console.WriteLine("Invalid option");
                        Console.Write("Try Again? [Y/N] : ");
                        x = Convert.ToChar(Console.ReadLine());
                        break;


                }




            }
        }
    }
    public class gencalc<T>
        {
            public T Addition(T a, T b)
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 + num2;
            }
            public T Subtraction(T a, T b)
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 - num2;
            }
            public T Mutliplication(T a, T b)
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 * num2;
            }
            public T Division(T a, T b)
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return num1 / num2;
            }
            public T Percentage(T a, T b)
            {
                dynamic num1 = a;
                dynamic num2 = b;
                return (num1 / num2) * 100;
            }
        }
    }
