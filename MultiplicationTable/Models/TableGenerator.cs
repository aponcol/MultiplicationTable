using System;
namespace MultiplicationTable.Models
{
    public class TableGenerator
    {
        const int defaultMatrixSize = 10;

		public TableGenerator()
        {
        }

        public int[,] GetTable(int matrix_size = defaultMatrixSize)
        {
            VerifyMatrixSize(matrix_size);
            int[,] table = BuildTableFromMatrixSize(matrix_size);
            return table;

        }

        private static int[,] BuildTableFromMatrixSize(int matrix_size)
        {
            int[,] table = new int[matrix_size, matrix_size];
            for (int i = 0; i < matrix_size; i++)
            {
                for (int j = 0; j < matrix_size; j++)
                {
                    int value = (i + 1) * (j + 1);
                    table[i, j] = value;
                }
            }

            return table;
        }

        private static void VerifyMatrixSize(int matrix_size)
        {
            if (matrix_size < 3)
            {
                throw new ArgumentException("Matrix Size too small!");
            }

            if (matrix_size > 15)
            {
                throw new ArgumentException("Matrix Size too big!");
            }
        }
    }
}
