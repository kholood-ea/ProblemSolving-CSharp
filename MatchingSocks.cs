using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank
{
    class MatchingSocks
    {

        // Complete the sockMerchant function below.
        public static int sockMerchant(int n, int[] ar)
        {
            int sockPairs = 0;

            HashSet<int> Numbers = new HashSet<int>();
            for (var i = 0; i < ar.Length; i++)
            {

                if (!Numbers.Contains(ar[i]))
                {
                    Numbers.Add(ar[i]);
                }
                else
                {
                    sockPairs++;
                    Numbers.Remove(ar[i]);
                }
            }

            return sockPairs;

        }

        public static void ReadVar()
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
            System.Console.WriteLine(result);
            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}