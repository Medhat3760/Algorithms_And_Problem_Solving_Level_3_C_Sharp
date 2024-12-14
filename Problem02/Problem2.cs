namespace Problem2
{
    internal class Problem2
    {

        // Sum Each Row In Matrix

        static Random random = new Random();

        static int RandomNumber(int from, int to)
        {

            return random.Next(from, to);

        }

        static void FillMatrixWithRandomNumbers(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = RandomNumber(1, 100);

                }

            }

        }

        static void PrintMatrix(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j],3}  ");

                }

                Console.WriteLine();

            }

        }

        static int RowSum(int[,] matrix, short rowNum)
        {

            int sum = 0;

            for (short j = 0; j < matrix.GetLength(1); j++)
            {

                sum += matrix[rowNum, j];

            }

            return sum;

        }

        static void PrintEachRowSum(int[,] matrix)
        {

            Console.WriteLine("\nThe following is a Sum Each Row In Matrix:");

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                Console.WriteLine($" Row {i + 1} Sum = {RowSum(matrix, i)}");

            }

        }

        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];

            FillMatrixWithRandomNumbers(matrix);

            Console.WriteLine("\nThe following is a 3x3 random matrix:");
            PrintMatrix(matrix);

            PrintEachRowSum(matrix);

        }
    }
}
