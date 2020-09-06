using System.Text;

namespace leetCode
{
    public class RemoveOuterParentheses
    {
        public static string removeOuterParentheses(string S)
        {
            StringBuilder res = new StringBuilder();

            int open, close, j;
            open = close = j = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                    open++;
                else
                    close++;

                if (open == close)
                {
                    res.Append(S.Substring(j + 1, i - j - 1));
                    j = i + 1;
                }
            }

            return res.ToString();
        }
    }

}