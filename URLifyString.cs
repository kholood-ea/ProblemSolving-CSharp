using System.Text;

namespace Problems
{
    public class URLifyString
    {
        // public static string URLify(string word, int length)//1st approach

        public static string URLify(string word, int length)
        {
            // ====================Seconed Approch=====================

            // char[] wordArr = word.ToCharArray();
            // int spcaeCount = 0, i = 0, index;
            // for (i = 0; i < length; i++)
            // {
            //     if (word[i] == ' ')
            //     {
            //         spcaeCount++;

            //     }

            // }
            // index = length + spcaeCount * 2;
            // if (length < word.Length) wordArr[length] = '\0';
            // for (i = length - 1; i >= 0; i--)
            // {
            //     if (wordArr[i] == ' ')
            //     {
            //         wordArr[index - 1] = '0';
            //         wordArr[index - 2] = '2';
            //         wordArr[index - 3] = '%';

            //     }
            //     else
            //     {
            //         wordArr[index - 1] = wordArr[i];
            //         i--;
            //     }
            // }

            // ====================First Approch=====================
            StringBuilder URL = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                URL.Append(word[i]);
            }
            return (URL.ToString()).Replace(" ", "%20");

        }
    }
}
//}