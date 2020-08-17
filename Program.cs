using System;

namespace cciProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode sec = new LinkedListNode('o');
            LinkedListNode first = new LinkedListNode('t', sec, null);
            LinkedListNode third = new LinkedListNode('t', null, sec);
            sec.setPrevious(first);
            System.Console.WriteLine(palindromeLL.checkPalindrome(first, third));

            // LinkedListNode sec1 = new LinkedListNode(9);
            // LinkedListNode first1 = new LinkedListNode(5, sec1, null);
            // LinkedListNode third1 = new LinkedListNode(2, null, sec1);
            // sec1.setPrevious(first1);

            // LinkedListNode result = SumList.sumList(first, first1, 0);
            // while (result != null)
            // {
            //     System.Console.WriteLine(result.data);
            //     result = result.next;
            // }
        }
    }
}
