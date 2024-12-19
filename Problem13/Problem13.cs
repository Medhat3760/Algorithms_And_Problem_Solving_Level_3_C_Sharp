namespace Problem13
{
    // Check Identity Matrix
    internal class Problem13
    {

        static void PrintMatrix(int[,] matrix)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($" {matrix[i, j],2}   ");

                }

                Console.WriteLine();

            }

        }

        static bool IsIdentityMatrix(int[,] matrix)
        {

            // check Diagonal elements are 1 and rest elements are 0

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {
                    // check for diagonals element
                    if (i == j && matrix[i, j] != 1)
                    {

                        return false;

                    }
                    // check for rest elements
                    else if (i != j && matrix[i, j] != 0)
                    {

                        return false;

                    }

                }

            }

            return true;

        }

        static void Main(string[] args)
        {

            //int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] matrix1 =
            {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };

            Console.WriteLine("\nmatrix1:");
            PrintMatrix(matrix1);

            if (IsIdentityMatrix(matrix1))
            {

                Console.WriteLine("\nYes: matrix is identity.");

            }
            else
            {

                Console.WriteLine("\nNo: matrix is NOT identity.");

            }

        }
    }
}