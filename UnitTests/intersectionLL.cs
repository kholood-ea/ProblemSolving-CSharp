using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace cciProblemSolving
{


    [TestClass]

    public class intersectionLLUnitTest
    {
        [TestMethod]
        public void intersectionShouldReturnNode()

        {
            LinkedListNode sec = new LinkedListNode(2);
            LinkedListNode first = new LinkedListNode(1, sec, null);
            LinkedListNode third = new LinkedListNode(3, null, null);
            // sec.setPrevious(first);
            sec.setNext(third);
            LinkedListNode forth = new LinkedListNode(4, sec, null);
            LinkedListNode fifth = new LinkedListNode(5, forth, null);
            Assert.AreEqual(sec, intersectionLL.isIntersect(first, fifth));
            Assert.AreEqual(sec, intersectionLL.isIntersect(first, sec));
            Assert.AreEqual(third, intersectionLL.isIntersect(first, third));
            Assert.AreEqual(sec, intersectionLL.isIntersect(first, forth));

        }
        [TestMethod]
        public void intersectionShouldReturnNull()

        {
            LinkedListNode sec = new LinkedListNode(2);
            LinkedListNode first = new LinkedListNode(1, sec, null);
            LinkedListNode third = new LinkedListNode(3, null, null);
            sec.setNext(third);
            LinkedListNode forth = new LinkedListNode(4, null, null);
            LinkedListNode sixth = new LinkedListNode(6, null, null);
            forth.setNext(sixth);
            LinkedListNode fifth = new LinkedListNode(5, forth, null);
            Assert.AreEqual(null, intersectionLL.isIntersect(first, fifth));
            Assert.AreEqual(null, intersectionLL.isIntersect(first, forth));
            Assert.AreEqual(null, intersectionLL.isIntersect(first, sixth));
        }
    }

}