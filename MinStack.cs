using System.Collections.Generic;
using System.Linq;

namespace leetCode
{
    public class MinStack : Stack<int>
    {
        public Stack<int> Stack = new Stack<int>();
        public MinStack()

        {

        }

        public void Push(int x)
        {
            if (Stack.Count == 0)
            {
                Stack.Push(x);
            }
            if (Stack.Peek() > x)
            {
                Stack.Push(x);
            }
            base.Push(x);
        }

        public void Pop()
        {
            if (this.Count < 0)
            {
                System.Console.WriteLine("empty stack");

            }
            if (this.ElementAt(0) == Stack.Peek())
            {
                Stack.Pop();
            }
            base.Pop();

        }

        public int Top()
        {
            if (this.Count == 0)
            {
                System.Console.WriteLine("empty stack");
            }
            return this.ElementAt(0);

            // return base.Peek();

        }

        public int GetMin()
        {
            if (this.Count == 0)
            {
                System.Console.WriteLine("empty stack");
            }
            return Stack.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */

}