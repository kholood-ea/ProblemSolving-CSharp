using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsTests
{
    [TestClass]
    public class letterOccurrenceUnitTest
    {
        [TestMethod]
        public void letterOccurreString()
        {
            Assert.AreEqual("a3b1c5a3", Problems.letterOccurrance.letterOccur("aaabcccccaaa"));
            Assert.AreEqual("a2b2c2", Problems.letterOccurrance.letterOccur("aabbcc"));
            Assert.AreEqual("abc", Problems.letterOccurrance.letterOccur("abc"));
            Assert.AreEqual("a4b1c5a3", Problems.letterOccurrance.letterOccur("aaaabcccccaaa"));


        }
    }
}