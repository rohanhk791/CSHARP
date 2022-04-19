﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Jagged_array
    {
        public static void Main()
        {
            Console.WriteLine("Jagged array concept");
            // Declare the Jagged Array of four elements:
            int[][] jagged_arr = new int[4][];

            // Initialize the elements
            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 10, 31, 69 };
            jagged_arr[2] = new int[] { 19, 21 };
            jagged_arr[3] = new int[] { 0, 15, 18, 23, 39 };

            // Display the array elements:
            for (int n = 0; n < jagged_arr.Length; n++)
            {

                // Print the row number
                System.Console.Write("Row({0}): ", n);

                for (int k = 0; k < jagged_arr[n].Length; k++)
                {

                    // Print the elements in the row
                    System.Console.Write("{0} ", jagged_arr[n][k]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
