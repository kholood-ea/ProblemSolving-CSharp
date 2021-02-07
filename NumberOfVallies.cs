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
    public class numberOfVallies
    {
        public static int countingValleys(int steps, string path)
        {
            int valleyCounter = 0, altitude = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    altitude++;
                    if (altitude == 0)
                    {
                        valleyCounter++;
                    }
                }
                else
                {

                    altitude--;
                }
            }
            return valleyCounter;
            // int seaLevel = 0, vallies = 0;
            // for (var i = 0; i < path.Length; i++)
            // {
            //     if (path[i] == 'D')
            //     {
            //         if (seaLevel == -1)
            //         {
            //             vallies++;
            //         }
            //         else
            //         {
            //             seaLevel--;
            //         }
            //     }

            //     if (path[i] == 'U')
            //     {
            //         if (seaLevel == +1)
            //         {
            //             vallies++;
            //         }
            //         else
            //         {
            //             seaLevel++;
            //         }
            //     }
            // }

            // return vallies;
        }


    }


    public class Solution
    {
        public static void readVar()
        {

            int steps = Convert.ToInt32(Console.ReadLine().Trim());



            string path = Console.ReadLine();

            int result = numberOfVallies.countingValleys(steps, path);


        }
    }
}