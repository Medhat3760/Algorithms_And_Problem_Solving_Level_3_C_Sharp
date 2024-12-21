namespace Problem19
{
    // Min/Max Number In Matrix
    internal class Problem19
    {

        static void PrintMatrix(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j],3}   ");

                }

                Console.WriteLine();

            }

        }

        static int MinNumberInMatrix(int[,] matrix)
        {

            int min = matrix[0, 0];

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }

                }

            }

            return min;

        }

        static int MaxNumberInMatrix(int[,] matrix)
        {

            int max = matrix[0, 0];

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }

                }

            }

            return max;

        }

        static void Main(string[] args)
        {

            int[,] matrix = { { 0, 10, 20 }, { -1, 20, 30 }, { 2, 30, 40 } };

            Console.WriteLine("\nMatrix:");
            PrintMatrix(matrix);

            Console.WriteLine("\nMinimum number in matrix is: " + MinNumberInMatrix(matrix));

            Console.WriteLine("\nMaximum number in matrix is: " + MaxNumberInMatrix(matrix));

        }
    }
}