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
    class JumpingOnClouds
    {

        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            int steps = 0;
            for (var i = 0; i < c.Length - 1; i++)
            {
                if (i == c.Length - 2)
                {
                    steps += 1;
                    continue;
                }
                if (c[i + 2] == 0)
                {
                    i++;
                    steps += 1;
                    continue;
                }
                else
                {
                    steps += 1;
                    continue;
                }
            }

            return steps;
        }

        static void ReadVar()
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '),
            cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);
            System.Console.WriteLine(result);

            // textWriter.WriteLine(result);
            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}