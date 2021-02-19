using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] g_from = { 1, 2, 2, 3 };
            int[] g_to = { 2, 3, 4, 5 };
            int nodes = 0, edges = 0, x = 0, y = 0;

            edges = Convert.ToInt32(Console.ReadLine());
            HashSet<int> adj = new HashSet<int>();
            for (var i = 0; i < edges; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());

            }

            // int[] x = { 6, 5, 2, 3, 5, 2, 2, 1, 1, 5, 1, 3, 3, 3, 5, };
            // =========================

            // string y = "UDDDUDUU";
            // System.Console.WriteLine(numberOfVallies.countingValleys(8, y));
            // =========================

            // int[] x = { 0, 0, 0, 1, 0, 0 };
            // System.Console.WriteLine(JumpingOnClouds.jumpingOnClouds(x));
            // =========================

            // string a = "cfimaakj";
            // System.Console.WriteLine(RepeatedA.repeatedString(a, 554045874191));
            // string a = "ab";
            // System.Console.WriteLine(RepeatedA.repeatedString(a, 4));
            // =========================

            // Waiter.waiter(x, 2);
            // ========================= 

            // System.Console.WriteLine(MatchingSocks.sockMerchant(15, x));
        }
    }
}
