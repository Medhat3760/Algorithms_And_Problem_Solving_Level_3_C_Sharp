namespace Problem21
{
    // Fibonacci Series
    internal class Problem21
    {

        static void PrintFibonacciUsingLoop(int number)
        {

            int febNumber = 0;
            int prev2 = 0, prev1 = 1;

            Console.Write(" 1 ");
            for (int i = 2; i <= number; i++)
            {

                febNumber = prev1 + prev2;
                Console.Write($" {febNumber} ");
                prev2 = prev1;
                prev1 = febNumber;

            }

        }

        static void Main(string[] args)
        {

            PrintFibonacciUsingLoop(10);

        }
    }
}