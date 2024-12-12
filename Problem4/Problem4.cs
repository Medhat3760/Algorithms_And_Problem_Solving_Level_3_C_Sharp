using System.Globalization;

namespace Problem4
{
    internal class Problem4
    {

        static Random random = new Random();

        static int RandomNumber(int from, int to)
        {

            return random.Next(from, to);

        }

        static void FillMatrixWithRandomNumbers(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = RandomNumber(1, 100);

                }

            }

        }

        static void PrintMatrix(int[,] matrix)
        {

            Console.WriteLine("\nThe following is a 3x3 Random matrix:");

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j],3}   ");

                }

                Console.WriteLine();

            }

        }

        static int ColSum(int[,] matrix, short colNumber)
        {

            int sum = 0;

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                sum += matrix[i, colNumber];

            }

            return sum;

        }

        static void PrintEachColSum(int[,] matrix)
        {

            Console.WriteLine("\nThe folloing are the sum of each col in the matrix:");

            for (short j = 0; j < matrix.GetLength(1); j++)
            {

                Console.WriteLine($" Col {j+1} Sum = " + ColSum(matrix, j));

            }

        }

        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];

            FillMatrixWithRandomNumbers(matrix);

            PrintMatrix(matrix);

            PrintEachColSum(matrix);

        }
    }
}
