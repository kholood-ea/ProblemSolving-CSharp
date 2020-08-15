using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace cciProblemSolving
{


    [TestClass]

    public class SumListUnitTest
    {
        [TestMethod]
        public void SumOf2LinkedListsSameLength()

        {
            LinkedListNode sec = new LinkedListNode(1);
            LinkedListNode first = new LinkedListNode(7, sec, null);
            LinkedListNode third = new LinkedListNode(6, null, sec);
            sec.setPrevious(first);

            LinkedListNode sec1 = new LinkedListNode(9);
            LinkedListNode first1 = new LinkedListNode(5, sec1, null);
            LinkedListNode third1 = new LinkedListNode(2, null, sec1);
            sec1.setPrevious(first1);

            LinkedListNode result = SumList.sumList(first, first1, 0);
            LinkedListNode sec2 = new LinkedListNode(1);
            LinkedListNode first2 = new LinkedListNode(2, sec2, null);
            LinkedListNode third2 = new LinkedListNode(9, null, sec2);
            sec2.setPrevious(first2);
            while (result != null && first2 != null)
            {
                Assert.AreEqual(result.data, first2.data);
                System.Console.WriteLine(result.data);
                result = result.next;
                first2 = first2.next;
            }

        }
        [TestMethod]
        public void SumOf2LinkedListsDifferentLength()

        {
            LinkedListNode sec = new LinkedListNode(1);
            LinkedListNode first = new LinkedListNode(7, sec, null);
            sec.setPrevious(first);

            LinkedListNode sec1 = new LinkedListNode(9);
            LinkedListNode first1 = new LinkedListNode(5, sec1, null);
            LinkedListNode third1 = new LinkedListNode(2, null, sec1);
            sec1.setPrevious(first1);

            LinkedListNode result = SumList.sumList(first, first1, 0);
            LinkedListNode sec2 = new LinkedListNode(1);
            LinkedListNode first2 = new LinkedListNode(2, sec2, null);
            LinkedListNode third2 = new LinkedListNode(3, null, sec2);
            sec2.setPrevious(first2);
            while (result != null && first2 != null)
            {
                Assert.AreEqual(result.data, first2.data);
                System.Console.WriteLine(result.data);
                result = result.next;
                first2 = first2.next;
            }

        }
    }

}