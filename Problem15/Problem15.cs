namespace Problem15
{
    // Count Number in Matrix
    internal class Problem15
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

                    if (number == matrix[i, j]) numberCount++;

                }

            }

            return numberCount;

        }

        static void PrintNumberCountInMatrix(int[,] matrix, int number)
        {

            Console.WriteLine($"\nnumber {number} count in matrix is {CountNumberInMatrix(matrix, number)}");

        }

        static void Main(string[] args)
        {

            int[,] matrix = { { 9, 0, 1 }, { 9, 2, 5 }, { 1, 9, 9 } };

            Console.WriteLine("\nMatrix:");
            PrintMatrix(matrix);

            Console.Write("\nEnter the number to count in matrix? ");
            int number = int.Parse(Console.ReadLine());

            PrintNumberCountInMatrix(matrix, number);

        }
    }
}
