using System;
// using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
namespace ProblemSolving.UnitTests
{

    [TestClass]

    public class duplicateRemovedUnitTest
    {
        [TestMethod]
        public void resultOfDuplicateRemovedFromLinkedList()
        {
            LinkedList<string> my_list = new LinkedList<string>();
            my_list.AddLast("the");
            my_list.AddLast("the");
            my_list.AddLast("fox");
            my_list.AddLast("jumps");
            my_list.AddLast("over");
            my_list.AddLast("the");
            my_list.AddLast("dog");
            LinkedList<string> my_list1 = new LinkedList<string>();
            my_list.AddLast("the");
            my_list.AddLast("fox");
            my_list.AddLast("jumps");
            my_list.AddLast("over");
            my_list.AddLast("dog");
            Problems.duplicateRemoved.removeDups(my_list.Head);
            LinkedListNode<String> previous = my_list.Head;
            LinkedListNode<String> previous1 = my_list1.Head;

            while (previous != null && previous1 != null)
            {

                Assert.AreEqual(previous.Value, previous1.Value);
                previous = previous.Next;
                previous1 = previous1.Next;

            }



        }
        [TestMethod]
        public void resultOfDuplicateRemovedFromLinkedListWithHashsetReturn()
        {
            // string[] words =
            //   { "the","the", "fox", "jumps", "over", "the", "dog" };
            // LinkedList<String> my_list = new LinkedList<String>(words);
            // HashSet<string> list1 = Problems.duplicateRemoved.removeDups(my_list);
            // HashSet<string> list = new HashSet<string> { "the", "fox", "jumps", "over", "dog" };
            // Assert.IsTrue(list.SetEquals(list1));
        }
    }
}