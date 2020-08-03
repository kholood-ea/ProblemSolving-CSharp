using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {

            // UniqueString.isUnique("Kholood");
            // PremutationString.isPremutation("abc", "123");
            // Console.WriteLine(URLifyString.URLify("Hello World   +    ", 11));
            // Console.WriteLine(PalindromMutation.IsPalindromMutattion("tot"));
            // Console.WriteLine(oneEdit.isOneEditAway("pale", "bale"));
            // letterOccurrance.letterOccur("aabcccccaaa");
            int[][] matrix = new int[3][] {
                new int[] { 0, 2,3 },
             new int[] { 4, 5,6 },
              new int[] { 7, 8,9 },
               };
            // System.Console.WriteLine(matrixRotation.rotate(matrix));
            matrix = zeroMatrix.zeroMatrixx(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    System.Console.WriteLine(string.Join(",", matrix[j]));

                }
            }
        }
    }
}
