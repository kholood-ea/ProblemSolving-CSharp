using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsTests
{
    [TestClass]
    public class zeroMatrixUnitTest
    {
        [TestMethod]
        public void zeroMatrix()

        {
            int[][] matrix = new int[3][] {
                new int[] { 0, 2,3 },
             new int[] { 4, 5,6 },
              new int[] { 7, 8,9 },
               };
            int[][] matrixx = new int[3][] {
                new int[] { 0, 0,0 },
             new int[] { 0, 5,6 },
              new int[] { 0, 8,9 },
               };
            int[][] matrix1 = Problems.zeroMatrix.zeroMatrixx(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Assert.AreEqual(matrixx[i][j], matrix1[i][j]);

                }
            }

        }
    }
}