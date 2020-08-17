namespace cciProblemSolving
{


    public class LinkedListNode
    {
        public LinkedListNode next, prev, last;
        public int data;
        public LinkedListNode(LinkedListNode[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    data = array[i].data;
                    // setPrevious(null);
                    if (array[i + 1] != null)
                    {
                        setNext(array[i + 1]);
                    }
                    else
                    {
                        setNext(null);
                    }
                }
                else
                {
                    data = array[i].data;
                    if (array[i + 1] != null)
                    {
                        setNext(array[i + 1]);
                    }
                    else
                    {
                        setNext(null);
                        // setPrevious(array[i-1]);
                    }
                }
            }
        }
        public LinkedListNode(int d, LinkedListNode n, LinkedListNode p)
        {
            data = d;
            setNext(n);
            setPrevious(p);
        }
        public LinkedListNode(int d)
        {
            data = d;
        }
        public LinkedListNode() { }
        public void setNext(LinkedListNode n)
        {
            next = n;
            if (this == last) { last = n; }
            if (n != null && n.prev != this)
            {
                n.setPrevious(this);
            }
        }
        public void setPrevious(LinkedListNode p)
        {
            prev = p;

            if (p != null && p.next != this)
            {
                p.setNext(this);
            }
        }
        public LinkedListNode clone()
        {
            LinkedListNode next2 = null; if (next != null)
            {
                next2 = next.clone();
            }
            LinkedListNode head2 = new LinkedListNode(data, next2, null); return head2;
        }
    }
}