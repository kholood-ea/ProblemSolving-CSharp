namespace Problems
{
    public class Partition
    {
        // ==========================Second Approach==============================

        public static LinkedListNode<int> partition(LinkedListNode<int> node, int x)
        {
            LinkedListNode<int> head = node;
            LinkedListNode<int> tail = node;
            while (node != null)
            {
                LinkedListNode<int> next = node.Next;
                if (node.Value < x)
                {
                    node.Next = head;
                    head = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;
                }
                node = next;
            }
            tail.Next = null;
            return head;
        }
        //==========================First Approach==============================
        // public static LinkedListNode<int> partition(LinkedListNode<int> node, int x)
        // {
        //     LinkedListNode<int> beforeStart = null;
        //     LinkedListNode<int> beforeEnd = null;
        //     LinkedListNode<int> afterStart = null;
        //     LinkedListNode<int> afterEnd = null;
        //     /*Partition list*/
        //     while (node != null)
        //     {
        //         LinkedListNode<int> next = node.Next;
        //         node.Next = null;
        //         if (node.Value < x)
        //         {
        //             if (beforeStart == null)
        //             {
        //                 beforeStart = node;
        //                 beforeEnd = beforeStart;
        //             }
        //             else
        //             {
        //                 beforeEnd.Next = node;
        //                 beforeEnd = node;
        //             }
        //         }
        //         else
        //         {

        //             if (afterStart == null)
        //             {
        //                 afterStart = node;
        //                 afterEnd = afterStart;
        //             }
        //             else
        //             {
        //                 afterEnd.Next = node;
        //                 afterEnd = node;
        //             }
        //         }
        //         node = next;
        //     }
        //     if (beforeStart == null)
        //     {
        //         return afterStart;
        //     }

        //     beforeEnd.Next = afterStart;
        //     return beforeStart;
        // }


    }
}