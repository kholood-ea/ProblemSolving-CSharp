using System;
using System.Collections.Generic;

namespace leetCode
{
public class FindJudge {
    public static int findJudge(int N, int[][] trust) {
int judge=0;
        int k=0;
        int[] trustCounts=new int[N+1];
        // Array.Fill<int>(trustCounts,0,0,1);
for (int i = 1; i < trust.GetLength(0)+1; i++)
{
    trustCounts[trust[k][1]]++;
    trustCounts[trust[k][0]]--;

    k++;
}
for (int j = 0; j < trustCounts.Length; j++)
{
    if(trustCounts[j]== N-1){
    judge =j ;
    }
}
if (judge==0)
{
    judge=-1;
}

//     List<int> rows=new List<int>();
//     List<int> cols=new List<int>();
//         for (int i = 0; i <trust.GetLength(0); i++)
//         {
//             rows.Add(trust[k,0]);
//             cols.Add(trust[k,1]);
//             k++;
//         }

//         for (int j = 0; j < cols.Count; j++)
//         {
//             if (!rows.Contains(cols[j]))
//             {
// judge= cols[j];
//            }

//            else
//            {
//                judge=-1;
//            }
//         }
       
        return judge;
    }
}
    
}

