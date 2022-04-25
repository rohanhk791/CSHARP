using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Csharp
{
    internal class Keys_and_Values_using_Dictionary_and_Hashtable
    {
        public static void Main()
        {
            Console.WriteLine("1. *****This is for dictionary***** ");
            Dictionary<Int16, string> Names = new Dictionary<Int16, string>();
            Names.Add(101, "A");
            Names.Add(102, "B");
            Names.Add(103, "C");
            Names.Add(104, "D");

            // Get and display keys  

            Dictionary<Int16, string>.KeyCollection keys = Names.Keys;
            foreach (Int16 key in keys)
            {
                Console.WriteLine("Keys are: {0}", key);
            }
            Dictionary<Int16, string>.ValueCollection values = Names.Values;
            foreach (string value in values)
            {
                Console.WriteLine("Values are: {0}\n", value);
            }
            Console.WriteLine("2. *****This is for Hashtable to storing key value pairs*****\n");
            Hashtable place = new Hashtable();

            // Adding key/value pair in the hashtable Using Add() method


            place.Add("mandya", "mdy");
            place.Add("mysore", "mys");
            place.Add("bangalore", "sbc");
            

            Console.WriteLine("3. *****key and Value pairs from place*****:\n");

            // For DictionaryEntry key use system.collections 

            foreach (DictionaryEntry de in place)
            {
                Console.WriteLine("{0} and {1} ", de.Key, de.Value);
            }
        }

    }
}
