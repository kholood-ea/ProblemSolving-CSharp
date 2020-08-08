using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class duplicateRemoved
    {
        // public static void removeDups(LinkedListNode<string> head)
        // {
        //     LinkedListNode<string> current = head;
        //     while (current != null)
        //     {
        //         /* Remove all future nodes that have the same value */
        //         LinkedListNode<string> runner = current;
        //         while (runner.Next != null)
        //         {
        //             if (runner.Next.Value == current.Value)
        //             {
        //                 runner.Next.Value = runner.Next.Next.Value;
        //             }
        //             else
        //             {
        //                 runner = runner.Next;
        //             }
        //         }
        //         current = current.Next;
        //     }
        // }
        //====================================================================
        // public static HashSet<string> removeDups(LinkedList<string> lista)
        // {
        //     HashSet<string> list = new HashSet<string>(lista);
        //     return list;
        // }
        //=======================First Approach===================================

        public static void removeDups(LinkedListNode<string> listItem)
        {
            HashSet<string> list = new HashSet<string>();
            LinkedListNode<String> previous = null;
            while (listItem != null)
            {
                if (list.Contains(listItem.Value))
                {
                    previous.Next = listItem.Next;
                }
                else
                {
                    list.Add(listItem.Value);
                    previous = listItem;
                }
                listItem = listItem.Next;
            }
        }
        // public static void removeDups1(System.Collections.Generic.LinkedListNode<string> listItem)
        // {
        //     HashSet<string> list = new HashSet<string>();
        //     System.Collections.Generic.LinkedListNode<String> previous = null;
        //     while (listItem != null)
        //     {
        //         if (list.Contains(listItem.Value))
        //         {
        //             previous.Next = listItem.Next;
        //         }
        //         else
        //         {
        //             list.Add(listItem.Value);
        //             previous = listItem;
        //         }
        //         listItem = listItem.Next;
        //     }
        // }





    }
}






//================Help================================

// public static bool CompareHashSets(HashSet<string> set1, HashSet<string> set2)
// {
// 	if(set1.Count != set2.Count)
// 		return false;

// 	HashSet<string>.Enumerator en1 = set1.GetEnumerator(); 
// 	HashSet<string>.Enumerator en2 = set2.GetEnumerator();

// 	while (en1.MoveNext() && en2.MoveNext()) { 
//         if (en1.Current != en2.Current) 
//         	return false;
//     } 

// 	return true;
// }
