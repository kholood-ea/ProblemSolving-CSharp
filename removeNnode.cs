namespace Problems
{
    public class removeNnode
    {
        public static void RemoveNode(LinkedListNode<int> node)
        {
            // node.Value = node.Next.Value;
            // node.Next = node.Next.Next;

            // ==============================
            node.Previous.Next = node.Next;

        }
    }
}