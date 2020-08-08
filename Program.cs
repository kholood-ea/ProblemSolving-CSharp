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
            LinkedList<int> my_list = new LinkedList<int>();
            my_list.AddLast(1);
            my_list.AddLast(2);
            my_list.AddLast(3);
            my_list.AddLast(4);

            // duplicateRemoved.removeDups(my_list.Head);
            // returnKthEle.returnKthElement(my_list.Head, 4);
            // int x = returnKthEle.printKthToLast(my_list.Head, 1);
            // System.Console.WriteLine(x);
            LinkedListNode<int> nth = returnKthEle.nthTolast(my_list.Head, 2);
            System.Console.WriteLine(nth.Value);
            System.Console.WriteLine(my_list.Tail.Value);
            // foreach (var item in my_list)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
