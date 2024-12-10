namespace Problem1
{
    internal class Problem1
    {

        // 3x3 Random Matrix

        static Random random = new Random();

        static int RandomNumber(int from, int to)
        {

            return random.Next(from, to);

        }

        static void FillMatrixWithRandomNumbers(int[,] arr)
        {

            for (short i = 0; i < arr.GetLength(0); i++)
            {

                for (short j = 0; j < arr.GetLength(1); j++)
                {

                    arr[i, j] = RandomNumber(1, 100);

                }

            }

        }

        static void PrintMatrix(int[,] arr)
        {

            for (short i = 0; i < arr.GetLength(0); i++)
            {

                for (short j = 0; j < arr.GetLength(1); j++)
                {

                    //Console.Write(matrix[i, j].ToString().PadLeft(3) + "   ");

                    Console.Write($"{arr[i,j],3}  "); // Format numbers to width 3

                }

                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {
             
            int[,] matrix = new int[3,3];

            FillMatrixWithRandomNumbers(matrix);

            Console.WriteLine("\nThe following is a 3x3 random matrix: ");
            PrintMatrix(matrix);

        }
    }
}