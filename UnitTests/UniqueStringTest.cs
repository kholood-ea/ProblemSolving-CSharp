using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsTests
{
    [TestClass]
    public class HasUniqueCharsUnitTest
    {
        [TestMethod]
        public void isUniqueShouldReturnFalse_AllCharsDuplicate()
        {
            Assert.AreEqual(false, Problems.UniqueString.isUnique("aaaaaaaaaaaaa"));

        }

        [TestMethod]
        public void CheckWordShouldReturnFalse_1st2CharsDuplicate()
        {
            Assert.AreEqual(false, Problems.UniqueString.isUnique("aabcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("bbcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("ccdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("ddefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("eefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("ffghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("gghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("hhijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("iijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("jjklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("kklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("llmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("aa"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("allmnopqrstuvwxyza"));




        }

        [TestMethod]
        public void isUniqueShouldReturnFalse_last2CharsDuplicate()
        {
            Assert.AreEqual(false, Problems.UniqueString.isUnique("abcdefghijklmnopqrstuvwxyzz"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("abcdefghijklmnopqrstuvwxyy"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("abcdefghijklmnopqrstuvwxx"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("abcdefghijklmnopqrstuvww"));
            Assert.AreEqual(false, Problems.UniqueString.isUnique("abcdefghijklmnopqrstuvv"));

        }


        [TestMethod]
        public void isUniqueShouldReturnTrue()
        {
            Assert.AreEqual(true, Problems.UniqueString.isUnique("abcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(true, Problems.UniqueString.isUnique("abcdefghijk lmnopqrstuvwxyz"));
            Assert.AreEqual(true, Problems.UniqueString.isUnique(""));
            Assert.AreEqual(true, Problems.UniqueString.isUnique("aA"));

        }

    }
}