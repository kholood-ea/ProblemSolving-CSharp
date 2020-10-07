using System;
using System.Collections.Generic;

namespace Problems
{

    public class SubArrays
    {
        // Recursive function to print all   
        // possible subarrays for given array  
        static void printSubArrays(int[] arr, int start, int end)
        {
            // Stop if we have reached  
            // the end of the array  
            if (end == arr.Length)
                return;

            // Increment the end point  
            // and start from 0  
            else if (start > end)
                printSubArrays(arr, 0, end + 1);

            // Print the subarray and  
            // increment the starting point  
            else
            {
                Console.Write("[");
                for (int i = start; i < end; i++)
                {
                    Console.Write(arr[i] + ", ");
                }

                Console.WriteLine(arr[end] + "]");
                printSubArrays(arr, start + 1, end);
            }
            return;
        }
        // Driver code 
        public static void ReadVar()
        {
            int[] arr = { 1, 2, 3 };
            printSubArrays(arr, 0, 0);
        }
    }

}