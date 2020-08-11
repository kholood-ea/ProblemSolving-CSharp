using System;
// using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
namespace ProblemSolving.UnitTests
{

    [TestClass]

    public class removeNnodeUnitTest
    {
        [TestMethod]
        public void removeNnode()
        {
            LinkedList<int> my_list = new LinkedList<int>();
            LinkedListNode<int> first = new LinkedListNode<int>(1);
            LinkedListNode<int> second = new LinkedListNode<int>(2);
            LinkedListNode<int> third = new LinkedListNode<int>(3);
            my_list.AddLast(first);
            my_list.AddLast(second);
            my_list.AddLast(third);
            my_list.Head.Next.Previous = my_list.Head;
            my_list.Tail.Previous = my_list.Head.Next;
            my_list.Head.Previous = null;

            LinkedList<int> my_list1 = new LinkedList<int>();
            LinkedListNode<int> first1 = new LinkedListNode<int>(1);
            LinkedListNode<int> third3 = new LinkedListNode<int>(3);
            my_list1.AddLast(first);
            my_list1.AddLast(third3);
            my_list1.Tail.Previous = my_list1.Head;
            Problems.removeNnode.RemoveNode(my_list.Head.Next);

            LinkedListNode<int> previous = my_list.Head;
            LinkedListNode<int> previous1 = my_list1.Head;

            while (previous != null && previous1 != null)
            {

                Assert.AreEqual(previous.Value, previous1.Value);
                previous = previous.Next;
                previous1 = previous1.Next;

            }



        }
    }
}