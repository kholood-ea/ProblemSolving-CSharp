using System;
using System.Collections;

namespace HackerRank
{
    class MainClass
    {

        public static string SearchingChallenge(string[] strArr)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < strArr.Length; i++)
            {
                if (!ht.ContainsKey(strArr[i][0]))
                {
                    ht.Add(strArr[i][0], Int16.Parse(strArr[i].Substring(2)));
                }
                else
                {
                    System.Console.WriteLine(ht[strArr[i][0]]);

                }

            }
            foreach (char k in ht.Keys)
            {
                System.Console.WriteLine(k);
                Console.WriteLine(ht[k]);
            }

            // code goes here  
            return "";

        }



    }
}