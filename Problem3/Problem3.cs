namespace Problem3
{
    internal class Problem3
    {

        // Sum Each Row In Matrix In Another Array

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

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j],3}  ");

                }

                Console.WriteLine();

            }

        }

        static int RowSum(int[,] matrix, short rowNumber)
        {

            int sum = 0;

            for (short j = 0; j < matrix.GetLength(1); j++)
            {

                sum += matrix[rowNumber, j];

            }

            return sum;

        }

        static void SumEachRowInMatrixInArray(int[,] matrix, int[] arrSum)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                arrSum[i] = RowSum(matrix, i);

            }

        }

        static void PrintRowsSumArray(int[] arrSum)
        {

            Console.WriteLine("\nThe following is a Sum Each Row In Matrix:");

            for (int i = 0; i < arrSum.Length; i++)
            {

                Console.WriteLine($" Row {i + 1} Sum = " + arrSum[i]);

            }

        }

        /* List
        static void SumEachRowInMatrixInList(int[,] matrix, List<int> lSumMatrixRows)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                int sum = 0;

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    sum += matrix[i, j];

                }

                lSumMatrixRows.Add(sum);

            }

        }

        static void PrintList(List<int> list)
        {

            short count = 1;

            foreach (int item in list)
            {

                Console.WriteLine($"Row {count} Sum = " + item);
                count++;
            }

        }
        */

        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];

            FillMatrixWithRandomNumbers(matrix);

            Console.WriteLine("\nThe following is a 3x3 random matrix:");
            PrintMatrix(matrix);

            int[] arrSum = new int[3];

            SumEachRowInMatrixInArray(matrix, arrSum);

            PrintRowsSumArray(arrSum);


            //List<int> lSumMatrixRows = new List<int>();

            //SumEachRowInMatrixInList(matrix, lSumMatrixRows);

            //Console.WriteLine("\nThe following is a Sum Each Row In Matrix:");
            //PrintList(lSumMatrixRows);

        }
    }
}