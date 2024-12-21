namespace Problem16_version2
{
    // Check Sparse Matrix
    internal class Problem16_version2
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

        static bool IsSparseMatrix(int[,] matrix)
        {

            float matrixSize = matrix.GetLength(0) * matrix.GetLength(1);

            short numberOfZeros = 0;

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] == 0) numberOfZeros++;

                    if (numberOfZeros >= (matrixSize / 2)) return true;

                }

            }

            return false;

        }

        static void Main(string[] args)
        {

            //int[,] matrix = { { 0, 0, 1 }, { 0, 2, 2 }, { 0, 12, 12 } }; // NOT sparse

            int[,] matrix = { { 0, 0, 1 }, { 0, 0, 2 }, { 0, 0, 12 } };

            Console.WriteLine("\nMatrix:");
            PrintMatrix(matrix);

            if (IsSparseMatrix(matrix))
            {

                Console.WriteLine("\nYes: matrix is sparse.");

            }
            else
            {

                Console.WriteLine("\nNo: matrix is NOT sparse.");

            }

        }
    }
}