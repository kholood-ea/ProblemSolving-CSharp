using System;
// using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
namespace ProblemSolving.UnitTests
{

    [TestClass]

    public class returnKthElementUnitTest
    {
        [TestMethod]
        public void resultOfDuplicateRemovedFromLinkedList()
        {
            LinkedList<int> my_list = new LinkedList<int>();
            my_list.AddLast(1);
            my_list.AddLast(2);
            my_list.AddLast(3);
            my_list.AddLast(4);

            Assert.AreEqual(my_list.Tail, Problems.returnKthEle.nthTolast(my_list.Head, 1));
            Assert.AreEqual(my_list.Head, Problems.returnKthEle.nthTolast(my_list.Head, 4));
            Assert.AreEqual(my_list.Head.Next, Problems.returnKthEle.nthTolast(my_list.Head, 3));
            Assert.AreEqual(my_list.Head.Next.Next, Problems.returnKthEle.nthTolast(my_list.Head, 2));



        }
    }
}