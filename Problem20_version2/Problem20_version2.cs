namespace Problem20_version2
{
    // Palindrome Matrix
    internal class Problem20_version2
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

        static bool IsPalindromeMatrix(int[,] matrix)
        {

            short lastColIndex = (short)(matrix.GetLength(1) - 1);

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j <= lastColIndex / 2; j++)
                {

                    if (matrix[i, j] != matrix[i, lastColIndex - j])
                    {
                        return false;
                    }

                }

            }

            return true;

        }

        static void Main(string[] args)
        {

            int[,] matrix = { { 1, 2, 1 }, { 5, 5, 5 }, { 7, 3, 7 } };

            Console.WriteLine("\nMatrix:");
            PrintMatrix(matrix);

            if (IsPalindromeMatrix(matrix))
            {

                Console.WriteLine("\nYes: Matrix is Palindrome.");

            }
            else
            {

                Console.WriteLine("\nNo: Matrix is NOT Palindrome.");

            }

        }
    }
}