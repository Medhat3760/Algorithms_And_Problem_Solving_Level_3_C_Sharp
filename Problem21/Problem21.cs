namespace Problem21
{
    // Fibonacci Series
    internal class Problem21
    {

        static void PrintFibonacciUsingLoop(int number)
        {

            int fibNumber = 0;
            int prev2 = 0, prev1 = 1;

            Console.Write(" 1 ");
            for (int i = 2; i <= number; i++)
            {

                fibNumber = prev1 + prev2;
                Console.Write($" {fibNumber} ");
                prev2 = prev1;
                prev1 = fibNumber;

            }

        }

        static void Main(string[] args)
        {

            PrintFibonacciUsingLoop(10);

        }
    }
}
