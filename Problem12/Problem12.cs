namespace Problem12
{
    // Check Typical Matrices
    internal class Problem12
    {

        static Random random = new Random();

        static int RandomNumber(int from, int to)
        {

            return random.Next(from, to + 1);

        }

        static void FillMatrixWithRandomNumbers(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = RandomNumber(1, 10);

                }

            }

        }

        static void PrintMatrix(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j]:D2}   ");

                }

                Console.WriteLine();

            }

        }

        static bool AreTypicalMatrices(int[,] matrix1, int[,] matrix2)
        {

            for (short i = 0; i < matrix1.GetLength(0); i++)
            {

                for (short j = 0; j < matrix1.GetLength(1); j++)
                {

                    if(matrix1[i, j] != matrix2[i, j])
                    return false;

                }

            }

            return true;

        }

        static void PrintIfMatricesAreTypicalOrNot(int[,] matrix1, int[,] matrix2)
        {

            if(AreTypicalMatrices(matrix1, matrix2))
            {

                Console.WriteLine("\nYes: both matrices are typical.");

            }
            else
            {

                Console.WriteLine("\nNo: matrices are NOT typical.");

            }

        }

        static void Main(string[] args)
        {

            int[,] matrix1 = new int[3,3],
                   matrix2 = new int[3,3];

            FillMatrixWithRandomNumbers(matrix1);

            FillMatrixWithRandomNumbers(matrix2);

            Console.WriteLine("\nMatrix1:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nMatrix2:");
            PrintMatrix(matrix2);

            PrintIfMatricesAreTypicalOrNot(matrix1, matrix2);

        }
    }
}