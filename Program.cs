using System;

namespace cciProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            StackWithMin2 obj = new StackWithMin2();
            // StackWithMin obj = new StackWithMin();
            // FixedMultiStack obj = new FixedMultiStack(5);
            // obj.push(0, 1);
            // obj.push(0, 2);
            // obj.push(0, 3);
            // obj.push(0, 4);
            // obj.push(0, 5);
            obj.push(1);
            obj.push(2);
            obj.push(3);
            obj.push(4);
            obj.push(5);
            foreach (var item in obj.s2)
            {
                Console.WriteLine(item);
            }
            // LinkedListNode sec = new LinkedListNode(2);
            // LinkedListNode first = new LinkedListNode(1, sec, null);
            // LinkedListNode third = new LinkedListNode(3, null, null);
            // // sec.setPrevious(first);
            // sec.setNext(third);
            // LinkedListNode forth = new LinkedListNode(4, sec, null);
            // LinkedListNode fifth = new LinkedListNode(5, forth, null);
            // System.Console.WriteLine(intersectionLL.isIntersect(first, third).data);
            // System.Console.WriteLine(palindromeLL.checkPalindrome(first, third));
            // while (a != null)
            // {
            //     System.Console.WriteLine(a.data);
            //     a = a.next;
            // }
            // LinkedListNode result = SumList.sumList(first, first1, 0);
            // while (result != null)
            // {
            //     System.Console.WriteLine(result.data);
            //     result = result.next;
            // }
        }
    }
}
