using System.Collections.Generic;

namespace leetCode
{
    public class MyStack
    {
        public Queue<int> qStack;

        /** Initialize your data structure here. */
        public MyStack()
        {
            qStack = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            qStack.Enqueue(x);
            for (int i = 0; i < qStack.Count - 1; i++)
            {
                qStack.Enqueue(qStack.Dequeue());
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            int x = qStack.Dequeue();
            // qStack.Dequeue();
            return x;
        }

        /** Get the top element. */
        public int Top()
        {
            int[] qarray = qStack.ToArray();
            System.Console.WriteLine();
            return qarray[0];
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return qStack.Count == 0 ? true : false;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}