using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public class Waiter
    {
        public static int[] waiter(int[] number, int q)
        {
            List<int> result = new List<int>();

            return result.ToArray();

        }

        public static void ReadVar()
        {

            string[] nq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nq[0]);

            int q = Convert.ToInt32(nq[1]);

            int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), numberTemp => Convert.ToInt32(numberTemp))
            ;
            int[] result = waiter(number, q);
            System.Console.WriteLine(string.Join("\n", result));


        }
    }
}