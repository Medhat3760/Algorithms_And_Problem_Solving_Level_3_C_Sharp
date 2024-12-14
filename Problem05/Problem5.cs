namespace Problem5
{
    internal class Problem5
    {

        // Sum Each Col In Matrix In Another Array

        static Random random = new Random();

        static int RandomNumbers(int from, int to)
        {

            return random.Next(from, to + 1);

        }

        static void FillMatrixWithRandomNumbers(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = RandomNumbers(1, 100);

                }

            }

        }

        static void PrintMatrix(int[,] matrix)
        {

            Console.WriteLine("\nThe following is a 3x3 random matrix:");

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

        static void SumMatrixColsInArray(int[,] matrix, int[] arrSum)
        {

            for (short j = 0; j < matrix.GetLength(1); j++)
            {

                arrSum[j] = ColSum(matrix, j);

            }

        }

        static void PrintColsSumArray(int[] arrSum)
        {

            Console.WriteLine("\nThe following is a Sum Each Col In Matrix:");

            for(short i=0; i < arrSum.Length; i++)
            {

                Console.WriteLine($" Col {i+1} Sum = " + arrSum[i]);

            }

        }

        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];
            int[] arrSum = new int[3];

            FillMatrixWithRandomNumbers(matrix);

            PrintMatrix(matrix);

            SumMatrixColsInArray(matrix, arrSum);

            PrintColsSumArray(arrSum);         

        }
    }
}
