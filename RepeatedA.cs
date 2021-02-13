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

    public class RepeatedA
    {

        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            // ex:"ab",5
            // numOfS=4/2=2
            long numOfS = n / s.Length;
            // 5%2=1
            long rest = n % s.Length;

            if (!s.Contains("a")) return 0;

            return s.Length > n ? aCounter(s, rest) :
             numOfS * aCounter(s, s.Length) + aCounter(s, rest);
        }

        // ex:("ab",2)
        private static long aCounter(String s, long end)
        {
            // a=1
            int a = 0;
            for (int i = 0; i < end; i++)
            {
                if (s[i] == 'a') a++;
            }
            return a;
            // // ex:"ab",4
            // // size=2, repeated = 4/2=2
            // long size = s.Length, repeated = n / size;
            // // left=4-(2*2)=0
            // long left = n - (size * repeated);
            // // extra = 1
            // int extra = 0;
            // // count=1
            // int count = 0;
            // for (int i = 0; i < size; i++)
            // {
            //     if (s[i] == 'a')
            //     {
            //         ++count;
            //     }
            // }

            // for (int i = 0; i < left; i++)
            // {
            //     if (s[i] == 'a')
            //     {
            //         ++extra;
            //     }
            // }
            // //  (2*1)+0=2
            // repeated = (repeated * count) + extra;

            // return repeated;

            // =================================
            // long numberOfAOccurance = 0;
            // if (s.Length == 1)
            // {
            //     return numberOfAOccurance = n;
            // }
            // StringBuilder x;
            // if (n <= s.Length)
            // {
            //     x = new StringBuilder(s.Substring(0, (int)n));
            // }
            // else
            // {
            //     x = new StringBuilder(s);

            //     for (var i = 0; i < s.Length; i++)
            //     {
            //         while (x.Length < n)
            //         {
            //             x.Append(s[i]);
            //             if (i == s.Length - 1)
            //             {
            //                 i = -1;
            //             }
            //             break;

            //         }
            //     }
            // }
            // for (var i = 0; i < x.Length; i++)
            // {
            //     if (x[i] == 'a')
            //     {
            //         numberOfAOccurance += 1;
            //     }
            // }


            // return numberOfAOccurance;
        }

        static void ReadVar()
        {

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
            System.Console.WriteLine(result);
        }
    }
}