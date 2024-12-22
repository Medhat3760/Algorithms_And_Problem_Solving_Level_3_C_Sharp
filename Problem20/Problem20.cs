namespace Problem20
{
    // Palindrome Matrix
    internal class Problem20
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

        static bool IsPalindromeNumber(int number)
        {

            int baseNumber = number;
            int reversedNumber = 0;
            int remainder = 0;

            while (number > 0)
            {

                remainder = number % 10;
                number = number / 10;
                reversedNumber = reversedNumber * 10 + remainder;

            }

            return baseNumber == reversedNumber;

        }

        static int RowNumbers(int[,] matrix, int rowIndex)
        {

            int rowNumbers = 0;

            for (short j = 0; j < matrix.GetLength(1); j++)
            {

                rowNumbers = rowNumbers * 10 + matrix[rowIndex, j];

            }

            return rowNumbers;

        }

        static bool IsPalindromeMatrix(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                int rowNumbers = RowNumbers(matrix, i);

                if (!IsPalindromeNumber(rowNumbers))
                {
                    return false;
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
