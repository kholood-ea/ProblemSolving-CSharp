namespace Problems
{
    public class matrixRotation
    {
        public static bool rotate(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length) return false;
            int n = matrix.Length;
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    // System.Console.WriteLine(offset);
                    // System.Console.WriteLine("================");
                    int top = matrix[first][i];//top
                    System.Console.WriteLine(top);

                    System.Console.WriteLine("================");
                    matrix[first][i] = matrix[last - offset][first];//left=>top
                    System.Console.WriteLine(matrix[last - offset][first]);
                    System.Console.WriteLine("================");


                    System.Console.WriteLine("================");
                    System.Console.WriteLine(matrix[last][last - offset]);
                    matrix[last - offset][first] = matrix[last][last - offset];//bottom=>left
                    System.Console.WriteLine(matrix[i][last]);
                    System.Console.WriteLine("================");


                    System.Console.WriteLine("================");
                    System.Console.WriteLine(matrix[last][last - offset]);
                    matrix[last][last - offset] = matrix[i][last];//right=>bottom
                    System.Console.WriteLine(matrix[i][last]);
                    System.Console.WriteLine("================");


                    System.Console.WriteLine("================");

                    System.Console.WriteLine(matrix[i][last]);
                    matrix[i][last] = top;//top=>right 
                    System.Console.WriteLine(matrix[i][last]);

                    System.Console.WriteLine("=================================");
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    System.Console.WriteLine(matrix[i][j]);
                }
            }
            return true;

        }
    }
}