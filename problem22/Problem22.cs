namespace Problem22
{
    // Fibonacci Series With Recursion
    internal class Problem22
    {

        static void PrintFibonacciUsinRecursion(int number, int prev1, int prev2)
        {

            int fibNumber = 0;

            if (number > 0)
            {

                fibNumber = prev1 + prev2;
                Console.Write($" {fibNumber} ");
                prev2 = prev1;
                prev1 = fibNumber;

                PrintFibonacciUsinRecursion(number - 1, prev1, prev2);

            }

        }

        static void Main(string[] args)
        {

            PrintFibonacciUsinRecursion(10, 0, 1);

        }
    }
}