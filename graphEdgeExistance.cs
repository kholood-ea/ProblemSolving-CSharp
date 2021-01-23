using System;
using System.Collections.Generic;

namespace leetCode
{
    public class GraphNodeExistance
    {
        public static void nodeExistis()
        {
            List<List<int>> adj = new List<List<int>>();
            int nodes, edges = 0, A = 0, B = 0, Queries, node1, node2;

            nodes = Convert.ToInt16(Console.ReadLine());
            edges = Convert.ToInt16(Console.ReadLine());

            for (var i = 0; i < edges; i++)
            {
                A = Convert.ToInt16(Console.ReadLine());
                B = Convert.ToInt16(Console.ReadLine());
                adj[A].Add(B);
                adj[B].Add(A);
            }
            Queries = Convert.ToInt16(Console.ReadLine());
            // bool answer = false;
            for (int j = 0; j < Queries; j++)
            {
                node1 = Convert.ToInt16(Console.ReadLine());
                node2 = Convert.ToInt16(Console.ReadLine());
                for (var k = 0; k < adj[node1].Count; k++)
                {
                    if (node2 == adj[node1][k])
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

            }

        }
    }
}