using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[,] array2D = new int[,] { { 1, 3 }, { 1, 4 }, { 2, 3 }, { 2, 4 } ,{4,3}};
                    //    int[,] array2D = new int[,] { { 1, 2 }};
            // int[][] array2D = new int[][] { { 1,3},{2,3},{3,1}};
int[][] array2D = new int[][]
{
    new int[] { 1, 3 },
    new int[] { 2, 3},
    new int[] { 3, 1 }
};
           System.Console.WriteLine( FindJudge.findJudge(3,array2D));
        // FindJudge.findJudge(3,array2D);
            // int[] array = { 1, 2, 3 };
            // MyStack qstack = new MyStack();
            // qstack.Push(1);
            // qstack.Push(2);
            // int x = qstack.Top();
            // int y = qstack.Pop();
            // bool z = qstack.Empty();
            // System.Console.WriteLine($"{x},{y},{z},{qstack.qStack.Count}");
            
            // Queue<int> queue = new Queue<int>();
            // queue.Enqueue(1);
            // queue.Enqueue(2);
            // queue.Enqueue(3);
            // queue.Dequeue();
            // System.Console.WriteLine(queue.Peek());
            // int[] array = queue.ToArray();
            // Queue<int> queue1 = new Queue<int>();
            // for (int i = array.Length - 1; i >= 0; i--)
            // {
            //     // queue1.Enqueue(array[i]);
            // }

            // foreach (var item in queue)
            // {
            //     System.Console.WriteLine(item);
            // }


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

            // foreach (var item in queue)
            // {
            //     // System.Console.WriteLine(item);
            // }
        }
    }
}
