using System;
using System.Collections;

namespace Problems
{
    public class UniqueString
    {
        public static Boolean isUnique(string word)
        {
            Hashtable ht = new Hashtable();

            for (int i = 0; i < word.Length; i++)
            {
                if (ht.ContainsValue(word[i]))
                {
                    Console.WriteLine("Not Unique");
                    return false;
                }
                ht.Add(i, word[i]);
            }

            Console.WriteLine("Unique");
            return true;
        }
    }
}