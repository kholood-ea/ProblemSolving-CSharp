using System;

namespace Problems
{
    public class oneEdit
    {
        public static bool isOneEditAway(string word1, string word2)
        {
            if (Math.Abs(word1.Length - word2.Length) > 1)
            {
                return false;
            }

            //long string
            string longString = word1.Length > word2.Length ? word1 : word2;
            string shortString = word1.Length > word2.Length ? word2 : word1;
            int index1 = 0, index2 = 0;
            bool foundDifference = false;

            while (index1 < longString.Length && index2 < shortString.Length)
            {
                if (longString[index1] != shortString[index2])
                {
                    if (foundDifference)
                    {
                        return false;

                    }
                    foundDifference = true;
                    if (longString.Length == shortString.Length)
                    {
                        index2++;
                    }
                }
                else
                {
                    index2++;
                }
                index1++;
            }
            return true;






            // ======================First approach===========================
            // if (word1.Length == word2.Length)
            // {
            //     bool foundDifference = false;

            //     for (int i = 0; i < word1.Length; i++)
            //     {
            //         if (word1[i] != word2[i])
            //         {
            //             if (foundDifference)
            //             {
            //                 return false;
            //             }
            //             else
            //             {
            //                 foundDifference = true;
            //             }

            //         }
            //     }
            //     return true;

            // }
            // if (word1.Length == word2.Length + 1 || word2.Length == word1.Length + 1)
            // {
            //     int index1 = 0;
            //     int index2 = 0;
            //     while (index1 < word1.Length && index2 < word2.Length)
            //     {
            //         if (word1[index1] != word2[index2])
            //         {
            //             if (index1 != index2)
            //             {
            //                 return false;
            //             }
            //             index2++;
            //         }
            //         index1++;
            //         index2++;
            //     }
            //     return true;
            // }



            // return false;
        }
    }
}