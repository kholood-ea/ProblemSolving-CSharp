namespace Problems
{
    public class stringRotation
    {
        public static bool isSubstring(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            string s3 = s2 + s2;
            if (s3.Contains(s1))
            {
                return true;
            }
            return false;
        }

    }
}