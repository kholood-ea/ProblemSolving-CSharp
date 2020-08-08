namespace Problems
{
    public class returnKthEle
    {
        public static LinkedListNode<int> nthTolast(LinkedListNode<int> head, int k)
        {
            LinkedListNode<int> p1 = head;
            LinkedListNode<int> p2 = head;
            /* Move p1 k nodes into the list.*/
            for (int i = 0; i < k; i++)
            {
                if (p1 == null) return null; // Out of bounds
                p1 = p1.Next;
            }
            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return p2;
        }
        // ================2nd Approach==================================================
        // public static int printKthToLast(LinkedListNode<int> head, int k)
        // {

        //     if (head == null)
        //     {
        //         return 0;
        //     }
        //     int index = printKthToLast(head.Next, k) + 1;
        //     if (index == k)
        //     {
        //         System.Console.WriteLine(k + "th to last node is " + head.Value);
        //     }
        //     return index;
        //}
        // ================First Approach==================================================
        // public static void returnKthElement(LinkedListNode<string> head, int k)
        // {
        //     int counter = 0;
        //     LinkedListNode<string> current = new LinkedListNode<string>();
        //     current = head;
        //     while (current != null)
        //     {
        //         if (counter == k)
        //         {
        //             // head.Previous = null;
        //             head = current;
        //             head.Next = null;
        //             break;
        //         }
        //         else
        //         {
        //             counter++;
        //             head = null;
        //             current = current.Next;
        //             // head = head.Next;
        //         }
        //     }


    }
}