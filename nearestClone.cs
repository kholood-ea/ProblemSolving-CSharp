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
    public class NearestClone
    {
        public static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {
            // solve here

            return 0;

        }


        static void ReadVar()
        {

            string[] graphNodesEdges = Console.ReadLine().Split(' ');
            int graphNodes = Convert.ToInt32(graphNodesEdges[0]);
            int graphEdges = Convert.ToInt32(graphNodesEdges[1]);
            int[] graphFrom = new int[graphEdges];
            int[] graphTo = new int[graphEdges];

            for (int i = 0; i < graphEdges; i++)
            {
                string[] graphFromTo = Console.ReadLine().Split(' ');
                graphFrom[i] = Convert.ToInt32(graphFromTo[0]);
                graphTo[i] = Convert.ToInt32(graphFromTo[1]);
            }



            long[] ids = Array.ConvertAll(Console.ReadLine().Split(' '), idsTemp => Convert.ToInt64(idsTemp));
            int val = Convert.ToInt32(Console.ReadLine());
            int ans = findShortest(graphNodes, graphFrom, graphTo, ids, val);
        }


    }
}