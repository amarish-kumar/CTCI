using System;

namespace Arrays___Strings
{
    class RotateMatrix
    {
        public static void Exec()
        {
            var matrix = _BuildMatrix(4);
            Utils.PrintMatrix(matrix);

            Console.WriteLine();

            var result = _Rotate90(matrix);
            Utils.PrintMatrix(result);

            //Rotate(matrix);
            //_PrintMatrix(matrix);

        }

        public static bool Rotate(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length)
                return false;

            int n = matrix.Length;

            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;

                    int top = matrix[first][i];

                    matrix[first][i] = matrix[last - offset][first];
                    matrix[last - offset][first] = matrix[last][last - offset];
                    matrix[last][last - offset] = matrix[i][last];
                    matrix[i][last] = top;
                }

            }
            return true;

        }
        private static int[][] _Rotate90(int[][] matrix)
        {
            var n = matrix.Length;

            if (n == 0 || matrix[0].Length != n)
                throw new Exception("Matrix is not a perfect square!");

            var copyMatrix = Utils.DeepClone(matrix);


            for (int row = 0; row < n; row += 1)
                for (int col = n - 1; col >= 0; col -= 1)
                    copyMatrix[row][n - col - 1] = matrix[col][row];

            return copyMatrix;
        }

        private static int[][] _BuildMatrix(int n)
        {
            var result = new int[n][];

            int start = 0;
            for (int i = 0; i < n; i += 1)
            {
                result[i] = new int[n];

                for (int j = 0; j < n; j += 1)
                    result[i][j] = ++start;
            }

            return result;
        }
    }
}