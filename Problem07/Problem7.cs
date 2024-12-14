namespace Problem7
{
    internal class Problem7
    {

        // Transpose Matrix

        static void FillMatrixWithRandomNumbers(int[,] matrix)
        {

            short counter = 0;

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    counter++;
                    matrix[i, j] = counter;

                }

            }

        }

        static void PrintMatrix(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j],2}   ");

                }

                Console.WriteLine();

            }

        }

        static void TransposeMatrix(int[,] matrix, int[,] matrixTransposed)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    matrixTransposed[i, j] = matrix[j, i];

                }

            }

        }

        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];
            int[,] matrixTransposed = new int[3, 3];

            FillMatrixWithRandomNumbers(matrix);

            Console.WriteLine("\nThe following is a 3x3 matrix:");
            PrintMatrix(matrix);

            TransposeMatrix(matrix, matrixTransposed);

            Console.WriteLine("\nThe following is the transposed matrix:");
            PrintMatrix(matrixTransposed);

        }
    }
}
