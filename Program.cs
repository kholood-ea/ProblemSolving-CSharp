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
        	 TreeNode first=new TreeNode(10);
              TreeNode sec=new TreeNode(5);
              TreeNode thr=new TreeNode(15);
               TreeNode four=new TreeNode(3);
                TreeNode fifth=new TreeNode(7);
                  TreeNode seven=new TreeNode(18);
                  first.left=sec;
                  first.right=thr;
                  sec.left=four;
                  sec.right=fifth;
                  thr.right=seven;
                  System.Console.WriteLine(TreeHighLow.RangeSumBST(first,7,15));



                //    TreeNode eight=new TreeNode(1);
                //     TreeNode nine=new TreeNode(1);
//       TreeNode left=new TreeNode(1);
//    TreeNode right=new TreeNode(2);
//                TreeNode root=new TreeNode(3,left,right);
//                 List<int>x=  PostOrderTree.postOrderTree(root);


//   List<int>x=  InOrderTree.inOrderTraversal(root);
//   LinkedList<int>x=  PostOrderTree.postOrderTraversal(root);
//   LinkedListNode<int>y=x.First;

// while (y!=null)
// {
//     System.Console.WriteLine(y.Value);
//     y = y.Next;
// }
        //  List<int>x=  PreOrderTree.PreorderTraversal(root);
        //  for (int i = 0; i < x.Count; i++)
        //  {
        //     System.Console.WriteLine( x[i]);
        //  }
        
// PreOrderTree.PreorderTraversal();
            // int[,] array2D = new int[,] { { 1, 3 }, { 1, 4 }, { 2, 3 }, { 2, 4 } ,{4,3}};
                    //    int[,] array2D = new int[,] { { 1, 2 }};
            // int[][] array2D = new int[][] { { 1,3},{2,3},{3,1}};
// int[][] array2D = new int[][]
// {
//     new int[] { 1, 3 },
//     new int[] { 2, 3},
//     new int[] { 3, 1 }
// };
        //    System.Console.WriteLine( FindJudge.findJudge(3,array2D));
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
