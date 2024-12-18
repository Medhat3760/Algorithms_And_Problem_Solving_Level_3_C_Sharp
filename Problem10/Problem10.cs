namespace Problem10
{
    // Sum Of Matrix
    internal class Problem10
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

        static int SumOfMatrix(int[,] matrix)
        {

            int sum = 0;

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    sum += matrix[i, j];

                }

            }

            return sum;

        }

        static void Main(string[] args)
        {

            int[,] matrix = new int[3,3];
            
            FillMatrixWithRandomNumbers(matrix);

            Console.WriteLine("\nMatrix1:");
            PrintMatrix(matrix);

            Console.WriteLine($"\nSum of Matrix = {SumOfMatrix(matrix)}");

        }
    }
}