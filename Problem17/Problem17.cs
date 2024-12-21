using MyLib;
namespace Problem17
{
    // Number Exists In Matrix
    internal class Problem17
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

        static short CountNumberInMatrix(int[,] matrix, int number)
        {

            short numberCount = 0;

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] == number) { numberCount++; }

                }

            }

            return numberCount;

        }

        static bool IsNumberExistsInMatrix(int[,] matrix, int number)
        {

            return CountNumberInMatrix(matrix, number) > 0;

        }

        static void Main(string[] args)
        {

            int[,] matrix =
            {
                {22, 90, 11 },
                {77, 30, 99 },
                {55, 33, 44 }
            };

            Console.WriteLine("\nMatrix:");
            PrintMatrix(matrix);

            int number = MyInputLib.ReadIntNumber("\nPlease enter a number to look for in matrix? ");

            if (IsNumberExistsInMatrix(matrix, number))
            {

                Console.WriteLine("Yes it is there.");

            }
            else
            {

                Console.WriteLine("No it is NOT there.");

            }

        }
    }
}