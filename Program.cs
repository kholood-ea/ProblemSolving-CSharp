using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            // UniqueString.isUnique("Kholood");
            // PremutationString.isPremutation("abc", "123");
            // Console.WriteLine(URLifyString.URLify("Hello World   +    ", 11));
            // Console.WriteLine(PalindromMutation.IsPalindromMutattion("tot"));
            // Console.WriteLine(oneEdit.isOneEditAway("pale", "bale"));
            // letterOccurrance.letterOccur("aabcccccaaa");
            // int[][] matrix = new int[3][] {
            //     new int[] { 0, 2,3 },
            //  new int[] { 4, 5,6 },
            //   new int[] { 7, 8,9 },
            //    };
            // System.Console.WriteLine(matrixRotation.rotate(matrix));
            // zeroMatrix.zeroMatrixx(matrix);
            // System.Console.WriteLine(stringRotation.isSubstring("waterbottel", "erbottelwa"));
            // LinkedList<string> my_list = new LinkedList<string>();

            // my_list.AddLast("the");
            // my_list.AddLast("the");
            // my_list.AddLast("fox");
            // my_list.AddLast("jumps");
            // my_list.AddLast("over");
            // my_list.AddLast("the");
            // my_list.AddLast("dog");
            // duplicateRemoved.removeDups(my_list.Head);
            // foreach (var item in my_list)
            // {
            //     System.Console.WriteLine(item);
            // }
            LinkedList<int> my_list = new LinkedList<int>();
            LinkedListNode<int> first = new LinkedListNode<int>(3);
            LinkedListNode<int> second = new LinkedListNode<int>(5);
            LinkedListNode<int> third = new LinkedListNode<int>(8);
            LinkedListNode<int> forth = new LinkedListNode<int>(5);
            LinkedListNode<int> fifth = new LinkedListNode<int>(10);
            LinkedListNode<int> sixth = new LinkedListNode<int>(2);
            LinkedListNode<int> seventh = new LinkedListNode<int>(1);
            my_list.AddLast(first);
            my_list.AddLast(second);
            second.Previous = first;
            my_list.AddLast(third);
            third.Previous = second;
            my_list.AddLast(forth);
            forth.Previous = third;
            my_list.AddLast(fifth);
            fifth.Previous = forth;
            my_list.AddLast(sixth);
            sixth.Previous = fifth;
            my_list.AddLast(seventh);
            seventh.Previous = sixth;
            // my_list.Head.Next.Previous = my_list.Head;
            // my_list.Tail.Previous = my_list.Head.Next;
            // my_list.Head.Previous = null;
            // my_list.AddLast(1);
            // my_list.AddLast(2);
            // my_list.AddLast(3);
            // my_list.AddLast(4);
            // returnKthEle.returnKthElement(my_list.Head, 4);
            // int x = returnKthEle.printKthToLast(my_list.Head, 1);
            // System.Console.WriteLine(x);
            // LinkedListNode<int> nth = returnKthEle.nthTolast(my_list.Head, 2);
            // System.Console.WriteLine(nth.Value);
            // removeNnode.RemoveNode(my_list.Head.Next);
            // LinkedListNode<int> result = new LinkedListNode<int>();
            // result = Partition.partition(my_list.Head, 5);
            // while (result != null)
            // {
            //     System.Console.WriteLine(result.Value);
            //     result = result.Next;
            // }
            // foreach (var item in my_list)
            // {
            //     System.Console.WriteLine(item);
            // }
            LinkedList<int> result = new LinkedList<int>();
            result = Partition.partition(my_list.Head, 5);

            while (result.Head != null)
            {
                System.Console.WriteLine(result.Head.Value);
                result.Head = result.Head.Next;
            }
        }
    }
}
