namespace cciProblemSolving
{
    public class palindromeLL
    {
        public static bool checkPalindrome(LinkedListNode l1, LinkedListNode l2)
        {
            while (l1 != l2)
            {
                if (l1.data != l2.data)
                {
                    return false;
                }
                l1 = l1.next;
                l2 = l2.prev;
            }
            return true;
        }
    }
}