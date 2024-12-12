namespace Problem6
{
    internal class Problem6
    {

        // 3x3 Ordered Matrix

        static void FillMatrixWithOrderedNumbers(int[,] matrix)
        {

            short counter = 0; 

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    counter++;
                    matrix[i, j] = counter;

                }

            }

        }

        static void PrintMatrix(int[,] matrix)
        {

            Console.WriteLine("\nThe following is a 3x3 ordered matrix:");

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j],2}   ");

                }

                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];

            FillMatrixWithOrderedNumbers(matrix);

            PrintMatrix(matrix);

        }
    }
}