using System;

namespace cciProblemSolving
{
    class intersectionLL
    {
        public static LinkedListNode isIntersect(LinkedListNode L1, LinkedListNode L2)
        {
            LinkedListNode intersection = new LinkedListNode();
            if (!checkTail(L1, L2))
            {
                intersection = null;
                return intersection;
            }
            else
            {
                int pointerDifference = Math.Abs(findLength(L1) - findLength(L2));
                LinkedListNode longNode =
                pointerDifference == 0 ? L1 : findLength(L1) > findLength(L2) ? L1 : L2;
                LinkedListNode shortNode =
                 pointerDifference == 0 ? L2 : findLength(L1) < findLength(L2) ? L1 : L2;
                LinkedListNode startingNode = pointerDifference == 0 ? L1 : returnKthNode(longNode, pointerDifference);

                while (startingNode != null && shortNode != null)
                {
                    if (startingNode == shortNode)
                    {
                        intersection = startingNode;
                        return intersection;
                    }
                    startingNode = startingNode.next;
                    shortNode = shortNode.next;
                }
                return null;
            }
            LinkedListNode returnKthNode(LinkedListNode L, int k)
            {
                LinkedListNode startingNode = new LinkedListNode();

                while (L != null && k > 0)
                {
                    L = L.next;
                    k--;
                }
                startingNode = L;
                return startingNode;


            }
            bool checkTail(LinkedListNode L1, LinkedListNode L2)
            {

                if (findTail(L1) == findTail(L2))
                {
                    return true;
                }
                return false;
            }
            LinkedListNode findTail(LinkedListNode L)
            {
                LinkedListNode Tail = new LinkedListNode();
                while (L != null)
                {
                    if (L.next == null)
                    {
                        Tail = L;
                    }
                    L = L.next;
                }
                return Tail;
            }
            int findLength(LinkedListNode L)
            {
                int Length = 0;
                while (L != null)
                {
                    Length++;
                    L = L.next;
                }
                return Length;
            }
        }
    }
}