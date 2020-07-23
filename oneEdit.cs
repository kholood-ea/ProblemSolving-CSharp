namespace Problems
{
    public class oneEdit
    {
        public static bool isOneEditAway(string word1, string word2)
        {

            if (word1.Length == word2.Length)
            {
                bool foundDifference = false;

                for (int i = 0; i < word1.Length; i++)
                {
                    if (word1[i] != word2[i])
                    {
                        if (foundDifference)
                        {
                            return false;
                        }
                        else
                        {
                            foundDifference = true;
                        }

                    }
                }
                return true;

            }
            if (word1.Length == word2.Length + 1 || word2.Length == word1.Length + 1)
            {
                int index1 = 0;
                int index2 = 0;
                while (index1 < word1.Length && index2 < word2.Length)
                {
                    if (word1[index1] != word2[index2])
                    {
                        if (index1 != index2)
                        {
                            return false;
                        }
                        index2++;
                    }
                    index1++;
                    index2++;
                }
                return true;

                // string smallWord;
                // string largeWord;

                // if (word1.Length > word2.Length)
                // {
                //     smallWord = word2;
                //     largeWord = word1;
                // }
                // else
                // {
                //     smallWord = word1;
                //     largeWord = word2;

                // }


                // if (largeWord.Contains(smallWord))
                // {
                //     return true;
                // }

            }



            return false;
        }
    }
}