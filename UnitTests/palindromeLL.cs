using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace cciProblemSolving
{


    [TestClass]

    public class palindromeLLUnitTest
    {
        [TestMethod]
        public void isPalindrome()

        {
            // LinkedListNode sec = new LinkedListNode('o');
            // LinkedListNode first = new LinkedListNode('t', sec, null);
            // LinkedListNode third = new LinkedListNode('t', null, sec);
            // sec.setPrevious(first);

            LinkedListNode first = new LinkedListNode('t');
            LinkedListNode sec = new LinkedListNode('o');
            LinkedListNode third = new LinkedListNode('o');
            LinkedListNode forth = new LinkedListNode('t');

            first.setNext(sec);
            first.setPrevious(null);

            sec.setNext(third);
            sec.setPrevious(first);

            third.setNext(forth);
            third.setPrevious(sec);

            forth.setNext(null);
            forth.setPrevious(third);
            Assert.AreEqual(true, palindromeLL.checkPalindrome(first, forth));


        }
        [TestMethod]
        public void isNotPalindrome()

        {
            LinkedListNode first = new LinkedListNode('k');
            LinkedListNode sec = new LinkedListNode('h');
            LinkedListNode third = new LinkedListNode('o');
            LinkedListNode forth = new LinkedListNode('l');
            LinkedListNode fifth = new LinkedListNode('o');
            LinkedListNode sixth = new LinkedListNode('o');
            LinkedListNode seventh = new LinkedListNode('d', null, sixth);
            first.setNext(sec);
            first.setPrevious(null);

            sec.setNext(third);
            sec.setPrevious(first);

            third.setNext(forth);
            third.setPrevious(sec);

            forth.setNext(fifth);
            forth.setPrevious(third);

            fifth.setNext(sixth);
            fifth.setPrevious(forth);

            sixth.setNext(seventh);
            sixth.setPrevious(fifth);

            seventh.setNext(null);
            seventh.setPrevious(sixth);

            Assert.AreEqual(false, palindromeLL.checkPalindrome(first, seventh));


        }
    }

}