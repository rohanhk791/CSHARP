using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace build
{
    internal class string_bui
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder("rohangowda", 20);

            //append method

            sb.Append("welcome");
            Console.WriteLine(sb);

            //insert method

            sb.Insert(3, "C#");
            Console.WriteLine(sb);

            //Remove method

            sb.Remove(5, 7);
            Console.WriteLine(sb);


        }
    }
}