﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    delegate int NumberChanger(int n);
       namespace DelegateAppl { 
       
            class TestDelegate
            {
                static int num = 10;
                public static int AddNum(int p)
                {
                    num += p; 
                    return num;
                }
                public static int MultNum(int q)
                {
                    num *= q;
                    return num;
                }
                    public static int getNum()
                    {
                        return num;
                    }
                    static void Main(string[] args)
                    {         //create delegate instances
                        NumberChanger nc1 = new NumberChanger(AddNum);
                        NumberChanger nc2 = new NumberChanger(MultNum);
                        //calling the methods using the delegate objects
                        nc1(25);

                        Console.WriteLine("Value of Num: {0}", getNum());
                nc2(10);
                Console.WriteLine("Value of Num: {0}", getNum());
                        Console.ReadKey(); 
            } 
        }

            }
        
    