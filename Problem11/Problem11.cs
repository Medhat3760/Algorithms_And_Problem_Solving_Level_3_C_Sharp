namespace Problem11
{
    // Check Matrices Equality
    internal class Problem11
    {

        static Random random = new Random();

        static int RandomNumber(int from, int to)
        {

            return random.Next(from, to + 1);

        }

        static void FillMatrixWithRandomNumbers(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = RandomNumber(1, 10);

                }

            }

        }

        static void PrintMatrix(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($" {matrix[i, j]:D2}   ");

                }

                Console.WriteLine();

            }

        }

        static int SumOfMatrixNumbers(int[,] matrix)
        {

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    sum += matrix[i, j];

                }

            }

            return sum;

        }

        static bool AreEqualMatrices(int[,] matrix1, int[,] matrix2)
        {

            return SumOfMatrixNumbers(matrix1) == SumOfMatrixNumbers(matrix2);

        }

        static void PrintMatricesAreEqualityOrNot(int[,] matrix1, int[,] matrix2)
        {

            if (AreEqualMatrices(matrix1, matrix2))
            {

                Console.WriteLine("\nYes: both matrices are Equal.");

            }
            else
            {

                Console.WriteLine("\nNo: matrices are NOT Equal.");

            }

        }

        static void Main(string[] args)
        {

            int[,] matrix1 = new int[3, 3],
                   matrix2 = new int[3, 3];

            FillMatrixWithRandomNumbers(matrix1);

            FillMatrixWithRandomNumbers(matrix2);

            Console.WriteLine("\nMatrix1:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nMatrix2:");
            PrintMatrix(matrix2);

            PrintMatricesAreEqualityOrNot(matrix1, matrix2);

        }
    }
}
