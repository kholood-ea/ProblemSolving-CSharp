
using System;
using System.Text;

namespace Problems
{

    public class letterOccurrance
    {
        public static string letterOccur(string word)
        {
            StringBuilder result = new StringBuilder();

            int numOfOccur = 0;
            for (int i = 0; i < word.Length; i++)
            {
                numOfOccur++;


                if (i + 1 >= word.Length || word[i] != word[i + 1])
                {
                    result.Append(word[i]);
                    result.Append(numOfOccur);
                    numOfOccur = 0;
                }
            }
            System.Console.WriteLine(result.ToString());

            return result.Length <= word.Length ? result.ToString() : word;
        }

    }
}