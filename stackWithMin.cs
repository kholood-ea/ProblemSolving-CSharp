
using System;
using System.Collections;
using System.Collections.Generic;

namespace cciProblemSolving
{
    public class StackWithMin2 : Stack<int>
    {
        //====================second approach==============
        public Stack<int> s2;
        public StackWithMin2()
        {
            s2 = new Stack<int>();
        }
        public void push(int value)
        {
            if (value <= min())
            {
                s2.Push(value);
            }

            base.Push(value);
        }
        public int pop()
        {
            int value = base.Pop();
            if (value == min())
            {
                s2.Pop();
            }
            return value;
        }
        public int min()
        {
            if (s2.Count == 0)

            {
                return int.MaxValue;
            }
            else
            {
                return s2.Peek();
            }
        }
    }
    //================Approch one===========================
    // public class NodeWithMin
    // {
    //     public int value;
    //     public int min;
    //     public NodeWithMin(int v, int min)
    //     {
    //         value = v;
    //         this.min = min;
    //     }
    // }
    // public class StackWithMin : Stack<NodeWithMin>
    // {
    //     public void push(int value)
    //     {
    //         int newMin = Math.Min(value, min());
    //         base.Push(new NodeWithMin(value, newMin));
    //     }
    //     public int min()
    //     {
    //         if (this.Count == 0)
    //         {
    //             return int.MaxValue;  // Error value
    //         }
    //         else
    //         {
    //             return Peek().min;
    //         }
    //     }


    // }
}

