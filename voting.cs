using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class voting
    {
            public static void Main()
            {
                int vote_age;
                Console.Write("\n\n");
                Console.Write("Check here for a eligible for voting:\n");
                Console.Write("----------------------------------------");
                Console.Write("\n\n");


                Console.Write("Enter your age? : ");
                vote_age = Convert.ToInt32(Console.ReadLine());
                if (vote_age < 18)
                {
                    Console.Write("Sorry, You are not eligible to vote.\n");
                    Console.Write("You would be able to vote after {0} year.\n\n", 18 - vote_age);
                }
                else
                    Console.Write("Congratulation! You are eligible for voting.\n\n");
            }
        }
    }
