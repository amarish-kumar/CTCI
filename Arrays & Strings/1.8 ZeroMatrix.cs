using System;

namespace Arrays___Strings
{
    class ZeroMatrix
    {
        public static void Exec()
        {
            var matrix = new int[][]
            {
                new int[] { 1, 0, 1, 1 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 0, 1, 1, 1 },
                new int[] { 1, 1, 0, 1 },
                new int[] { 1, 1, 1, 1 }
            };

            Utils.PrintMatrix(matrix);

            var result = _Nullify(matrix);

            Console.WriteLine();
            Utils.PrintMatrix(result);
        }

        private static int[][] _Nullify(int[][] matrix)
        {
            var copyMatrix = Utils.DeepClone(matrix);


            for (int row = 0; row < matrix.Length; row += 1)
                for (int col = 0; col < matrix[0].Length; col += 1)
                    if (matrix[row][col] == 0)
                    {
                        for (int i = 0; i < matrix.Length; i += 1)
                            copyMatrix[i][col] = 0;

                        for (int i = 0; i < matrix[0].Length; i += 1)
                            copyMatrix[row][i] = 0;
                    }

            return copyMatrix;
        }
    }
}