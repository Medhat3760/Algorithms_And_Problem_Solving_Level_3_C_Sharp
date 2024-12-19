namespace Problem14
{
    // Check Scalar Matrix
    internal class Problem14
    {

        static void PrintMatrix(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($" {matrix[i, j],2}   ");

                }

                Console.WriteLine();

            }

        }

        static bool IsScalarMatrix(int[,] matrix)
        {

            int firstDiagElement = matrix[0, 0];

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    if (i == j && matrix[i, j] != firstDiagElement)
                    {

                        return false;

                    }
                    else if (i != j && matrix[i, j] != 0)
                    {

                        return false;

                    }

                }

            }

            return true;

        }

        static void Main(string[] args)
        {

            int[,] matrix1 =
            {
                {9, 0, 0 },
                {0, 9, 0 },
                {2, 0, 9 }
            };

            Console.WriteLine("\nMatrix1:");
            PrintMatrix(matrix1);

            if (IsScalarMatrix(matrix1))
            {

                Console.WriteLine("\nYes: matrix is scalar.");

            }
            else
            {

                Console.WriteLine("\nNo: matrix is NOT scalar");

            }

        }
    }
}