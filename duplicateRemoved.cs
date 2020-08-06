using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class duplicateRemoved
    {



        // public static void deleteDups(LinkedListNode<string> head)
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

                    // list.Add(i, listItem.Value);
                    previous = listItem;
                }
                listItem = listItem.Next;
            }
            // return list;


        }


    }
}