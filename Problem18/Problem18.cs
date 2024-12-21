namespace Problem18
{
    // Intersected Numbers In Matrices
    internal class Problem18
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

        static bool IsNumberExistsInMatrix(int[,] matrix, int number)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] == number)
                        return true;

                }

            }

            return false;

        }

        static void PrintMatricesIntersectedNumbers(int[,] matrix1, int[,] matrix2)
        {

            Console.WriteLine("\nInsected Numbers are:\n");

            int number = 0;

            for (short i = 0; i < matrix1.GetLength(0); i++)
            {

                for (short j = 0; j < matrix1.GetLength(1); j++)
                {

                    number = matrix1[i, j];

                    if (IsNumberExistsInMatrix(matrix2, number))
                    {

                        Console.Write($"{matrix1[i, j],3}  ");

                    }


                }

            }

            Console.WriteLine();

        }

        static void Main(string[] args)
        {

            int[,] matrix1 = { { 0, 77, 99 }, { 1, 10, 22 }, { 1, 44, 33 } };
            int[,] matrix2 = { { 30, 1, 9 }, { 77, 30, 22 }, { 99, 44, 50 } };

            Console.WriteLine("\nMatrix1:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nMatrix2:");
            PrintMatrix(matrix2);

            PrintMatricesIntersectedNumbers(matrix1, matrix2);

        }
    }
}
