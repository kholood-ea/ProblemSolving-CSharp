using System;
// using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
namespace ProblemSolving.UnitTests
{

    [TestClass]

    public class SumListUnitTest
    {
        [TestMethod]
        public void SumOf2LinkedLists()

        {
            LinkedList<int> my_list = new LinkedList<int>();
            LinkedListNode<int> first = new LinkedListNode<int>(7);
            LinkedListNode<int> second = new LinkedListNode<int>(1);
            LinkedListNode<int> third = new LinkedListNode<int>(6);
            my_list.AddLast(first);
            my_list.AddLast(second);
            second.Previous = first;
            my_list.AddLast(third);
            third.Previous = second;
            LinkedList<int> my_list1 = new LinkedList<int>();
            LinkedListNode<int> first1 = new LinkedListNode<int>(5);
            LinkedListNode<int> second2 = new LinkedListNode<int>(9);
            LinkedListNode<int> third3 = new LinkedListNode<int>(2);
            my_list1.AddLast(first1);
            my_list1.AddLast(second2);
            second2.Previous = first1;
            my_list1.AddLast(third3);
            third3.Previous = second2;

            LinkedList<char> my_list2 = sumList.SumList(my_list, my_list1);
            LinkedList<char> my_list3 = new LinkedList<char>();
            my_list3.AddLast('2');
            my_list3.AddLast('1');
            my_list3.AddLast('9');

            while (my_list2.Head != null && my_list3.Head != null)
            {
                Assert.AreEqual(my_list2.Head.Value, my_list3.Head.Value);
                my_list2.Head = my_list2.Head.Next;
                my_list3.Head = my_list3.Head.Next;
            }

        }

        [TestMethod]
        public void SumOf2LinkedListsTestCase2()

        {
            LinkedList<int> my_list = new LinkedList<int>();
            LinkedListNode<int> first = new LinkedListNode<int>(0);
            LinkedListNode<int> second = new LinkedListNode<int>(0);
            LinkedListNode<int> third = new LinkedListNode<int>(1);
            my_list.AddLast(first);
            my_list.AddLast(second);
            second.Previous = first;
            my_list.AddLast(third);
            third.Previous = second;
            LinkedList<int> my_list1 = new LinkedList<int>();
            LinkedListNode<int> first1 = new LinkedListNode<int>(0);
            LinkedListNode<int> second2 = new LinkedListNode<int>(0);
            LinkedListNode<int> third3 = new LinkedListNode<int>(2);
            my_list1.AddLast(first1);
            my_list1.AddLast(second2);
            second2.Previous = first1;
            my_list1.AddLast(third3);
            third3.Previous = second2;

            LinkedList<char> my_list2 = sumList.SumList(my_list, my_list1);
            LinkedList<char> my_list3 = new LinkedList<char>();
            my_list3.AddLast('0');
            my_list3.AddLast('0');
            my_list3.AddLast('3');

            while (my_list2.Head != null && my_list3.Head != null)
            {
                Assert.AreEqual(my_list2.Head.Value, my_list3.Head.Value);
                my_list2.Head = my_list2.Head.Next;
                my_list3.Head = my_list3.Head.Next;
            }

        }
    }
}