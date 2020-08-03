namespace Problems
{
    class zeroMatrix
    {
        public static int[][] zeroMatrixx(int[][] matrix)
        {
            bool rowHasZero = false;
            bool colHasZero = false;
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    rowHasZero = true;
                    break;
                }
            }
            for (int j = 0; j < matrix.Length; j++)
            {
                if (matrix[j][0] == 0)
                {
                    colHasZero = true;
                    break;
                }
            }
            for (int i = 1; i < matrix.Length; i++)
            {

                for (int k = 1; k < matrix[0].Length; k++)
                {
                    if (matrix[i][k] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][k] = 0;
                    }
                }
            }
            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    nullifyRow(matrix, i);
                }
            }
            for (int i = 1; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 0)
                {
                    nullifyRow(matrix, i);
                }
            }
            if (rowHasZero) nullifyRow(matrix, 0);
            if (colHasZero) nullifyCol(matrix, 0);

            //=======================First Approach========================================
            // bool[] row = new bool[matrix.Length];
            // bool[] col = new bool[matrix[0].Length];
            // for (int i = 0; i < matrix.Length; i++)
            // {
            //     for (int j = 0; j < matrix[0].Length; j++)
            //     {


            //         if (matrix[i][j] == 0)
            //         {
            //             row[i] = true;
            //             col[j] = true;

            //         }
            //     }
            // }
            // for (int i = 0; i < row.Length; i++)
            // {
            //     if (row[i])
            //     {
            //         nullifyRow(matrix, i);
            //     }
            // }
            // for (int i = 0; i < col.Length; i++)
            // {
            //     if (col[i])
            //     {
            //         nullifyCol(matrix, i);
            //     }
            // }
            // =============================================================
            void nullifyRow(int[][] matrix, int row)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    matrix[row][i] = 0;
                }
            }
            void nullifyCol(int[][] matrix, int col)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][col] = 0;
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {


                System.Console.WriteLine(string.Join(",", matrix[i]));
            }
            return matrix;
            // return string.Join(",", matrix.ToString());

        }
    }
}