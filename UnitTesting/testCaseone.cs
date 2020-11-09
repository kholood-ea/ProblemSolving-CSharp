using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace leetCode
{


    [TestClass]

    public class FindJudgeUnitTest
    {
        [TestMethod]
        public void findJudgeShouldReturnValue()

        {
int[][] array2D = new int[][]
{
    new int[] { 1, 3 },
    new int[] { 1, 4 },
    new int[] { 2, 3 },
    new int[] { 2, 4 },
    new int[] { 4, 3 },
};
int[][] array2D1 = new int[][]
{
    new int[] { 1, 2},
};
int[][] array2D2 = new int[][]
{
    new int[] { 1, 3 },
    new int[] { 2, 3 }
};
            Assert.AreEqual(3,FindJudge.findJudge(4,array2D));
            Assert.AreEqual(2,FindJudge.findJudge(2,array2D1));
            Assert.AreEqual(3,FindJudge.findJudge(3,array2D2));

         }
        [TestMethod]
        public void findJudgeShouldReturnMin1()

        {
int[][] array2D = new int[][]
{
    new int[] { 1, 3 },
    new int[] { 2, 3 },
        new int[] { 3, 1 },

};
int[][] array2D1 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 2, 3 },
};
            Assert.AreEqual(-1,FindJudge.findJudge(3,array2D));
            Assert.AreEqual(-1,FindJudge.findJudge(3,array2D1));
        }
    }

}