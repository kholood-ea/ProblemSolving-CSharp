using System;
using System.Collections;
using System.Linq;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);



            // MinStack stack = new MinStack();
            // foreach (var item in array)
            // {
            //     stack.Push(item);
            // }
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);
            // int x = stack.GetMin();
            // stack.Pop();
            // int y = stack.GetMin();

            // int y = stack.Top();
            // System.Console.WriteLine(x);
            // System.Console.WriteLine(y);
            // System.Console.WriteLine(stack.ElementAt(0));
            // stack.Pop();
            // stack.Pop();
            // stack.Pop();
            // stack.Pop();

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
