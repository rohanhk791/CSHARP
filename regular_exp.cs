using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Csharp
{
    internal class Regularex
    {
        public static void name()
        {
            string[] names = {"rohan", "mohan","deepak"};
            var result = new Regex(@".ohan", RegexOptions.Compiled);
            foreach (string word in names)
            {
                if (result.IsMatch(word))
                {
                    Console.WriteLine(word + "Match");
                }
                else
                {
                    Console.WriteLine(word + "does not match");
                }
            }

        }
        public static void MobileValidation()
        {
            string[] mobile = { "9916801289", "6362554060" };
            foreach (string m in mobile)
            {
                Console.WriteLine(m);
                Console.WriteLine(checkMobile(m));
            }
        }
        public static bool checkMobile(string mobile)
        {
            string mregexp = @"(^[0-7]{10}$)";
            Regex r = new Regex(mregexp);
            if (r.IsMatch(mobile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    public static void Main()
        {
           
                
                name();
                MobileValidation();
                Console.ReadLine();
            }
        }
    
    }

