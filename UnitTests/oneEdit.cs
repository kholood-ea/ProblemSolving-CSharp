using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSolving.UnitTests
{

    [TestClass]

    public class oneEditUnitTest
    {
        [TestMethod]
        public void isOneEditAwayShouldReturnFalse()
        {
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("pale", "bake"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("abc", "def"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("abcd", "efg"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("pool", "plaa"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("    ", "@#@$"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("cat", "tac"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("dog", "god"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("pick", "bikc"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("boy", "boooy"));
            Assert.AreEqual(false, Problems.oneEdit.isOneEditAway("why", "y"));

        }
        [TestMethod]
        public void isOneEditAwayShouldReturnTrue()
        {
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("pale", "ple"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("pales", "pale"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("pale", "bale"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("abc", "abcd"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("abcd", "abc"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("dddd", "ddd"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("good", "god"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("pick", "bick"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("boy", "booy"));
            Assert.AreEqual(true, Problems.oneEdit.isOneEditAway("why", "hy"));

        }

    }
}