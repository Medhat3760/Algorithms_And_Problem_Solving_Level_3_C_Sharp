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

        static bool IsNumberExistsInMatrix(int[,] matrix, int number)
        {

            for (short i = 0; i < matrix.GetLength(0); i++)
            {

                for (short j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] == number) return true;

                }
            }

            return false;

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

            Console.WriteLine("\nPlease enter a number to look for in matrix? ");
            int number = int.Parse(Console.ReadLine());

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
