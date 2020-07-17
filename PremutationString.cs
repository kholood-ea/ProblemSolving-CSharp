using System;
using System.Collections;
using System.Linq;


namespace Problems
{
    public class PremutationString
    {
        public static Boolean isPremutation(string firstWord, string seconedWord)
        {

            // ===================Seconed Approch===========================

            // if (firstWord.Length == seconedWord.Length)
            // {
            //     Hashtable ht = new Hashtable();
            //     Hashtable ht1 = new Hashtable();

            //     for (int i = 0; i < firstWord.Length; i++)
            //     {
            //         ht.Add(i, firstWord[i]);
            //         ht1.Add(i, seconedWord[i]);

            //     }

            //     for (int i = 0; i < ht.Count; i++)
            //     {

            //         if (!ht.ContainsValue(ht1[i]))
            //         {
            //             Console.WriteLine("strings are not permutations");
            //             return false;
            //         }
            //     }
            //     Console.WriteLine("strings are  permutations");
            //     return true;
            // }
            // Console.WriteLine("strings are not permutations");
            // return false;
            // ===================First Approch===========================

            string sort(string word)
            {
                char[] sortedArr = word.ToArray();
                Array.Sort(sortedArr);

                return new String(sortedArr);

            }
            if (firstWord.Length != seconedWord.Length)
            {
                System.Console.WriteLine(sort(firstWord).Equals(sort(seconedWord)));

                return false;
            }

            System.Console.WriteLine(sort(firstWord).Equals(sort(seconedWord)));
            return sort(firstWord).Equals(sort(seconedWord));
            //=========================================================================
            // if (firstWord.Length == seconedWord.Length)
            // {


            //     char[] firstWordArr = firstWord.ToCharArray();
            //     char[] seconedWordArr = seconedWord.ToCharArray();

            //     Array.Sort(firstWordArr);
            //     Array.Sort(seconedWordArr);


            //     for (int i = 0; i < firstWordArr.Length; i++)
            //     {
            //         if (firstWordArr[i] != seconedWordArr[i])
            //         {
            //             System.Console.WriteLine("strings are not permutations");
            //             return false;
            //         }
            //         else
            //         {
            //             System.Console.WriteLine("strings are permutations");
            //             return true;

            //         }
            //     }
            // }
            // System.Console.WriteLine("strings are not permutations");
            // return false;
            // ===========================================================
        }
    }
}