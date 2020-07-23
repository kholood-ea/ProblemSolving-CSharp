using System;
using System.Collections;

namespace Problems
{
    public class PalindromMutation
    {

        public static bool IsPalindromMutattion(string word)
        {

            Hashtable hashtable = new Hashtable();
            int OccurrenceNo = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (hashtable.ContainsKey(word[i]))
                {
                    int old = (int)hashtable[word[i]];
                    hashtable[word[i]] = old + 1;
                }
                else
                {
                    hashtable.Add(word[i], 1);
                }
            }
            foreach (char i in hashtable.Keys)
            {
                if ((int)hashtable[i] % 2 == 1)
                {
                    OccurrenceNo++;
                }
                System.Console.WriteLine(hashtable[i]);
            }
            if (OccurrenceNo > 1)
            {
                return false;
            }
            else
            {

            }
            return true;

        }
    }
}