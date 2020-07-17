using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsTests
{
    [TestClass]
    public class isPremutationUnitTest
    {
        [TestMethod]
        public void isPermutationReturnFalse_AllCharsDuplicate()
        {
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("aaa", "AAA"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("aaa", "bbb"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("aaa", "aa"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("bbb", "bb"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("BBB", "AAA"));

        }
        [TestMethod]
        public void isPermutationReturnFalse()
        {
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("aa", "AAA"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("aa aa", "aaaa"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("abc", "bcd"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("Hello", "hello"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("sdfsadfasdfas", "cvbvbxcvbcxvb"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("xcvx", "rrwerwe"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("1234234", "456456"));
            Assert.AreEqual(false, Problems.PremutationString.isPremutation("!@#!%@", "*&^*(&^*"));
        }
        [TestMethod]

        public void isPermutationReturnTrue()
        {
            Assert.AreEqual(true, Problems.PremutationString.isPremutation("hello!", "!hlloe"));
            Assert.AreEqual(true, Problems.PremutationString.isPremutation("hello World", " Whelloorld"));
            Assert.AreEqual(true, Problems.PremutationString.isPremutation("abcdefg", "badefcg"));
            Assert.AreEqual(true, Problems.PremutationString.isPremutation("AAA AAA", "AA AAAA"));
            Assert.AreEqual(true, Problems.PremutationString.isPremutation("!@#$%^&*()", ")!@(#*$&%^"));

        }

    }
}