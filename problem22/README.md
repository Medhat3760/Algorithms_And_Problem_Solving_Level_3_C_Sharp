# Fibonacci Series Using Recursion

This program demonstrates how to generate and print the Fibonacci series using recursion in C#. The Fibonacci series is a sequence of numbers where each number is the sum of the two preceding ones, typically starting with 0 and 1.

## Code Explanation

### Namespace and Class
The program is contained within the `Problem22` namespace and implemented in the `Problem22` class.

### Methods

#### `PrintFibonacciUsinRecursion`
- **Parameters:**
  - `number`: The number of Fibonacci terms to generate.
  - `prev1`: The previous term in the Fibonacci sequence.
  - `prev2`: The term before `prev1`.
- **Purpose:**
  - Uses recursion to calculate and print the Fibonacci series.
  - Prints the next Fibonacci number by summing `prev1` and `prev2`.
  - Recursively calls itself with decremented `number` and updated `prev1` and `prev2`.
- **Base Case:** Stops recursion when `number` becomes 0.

#### `Main`
- Initializes the Fibonacci sequence by calling `PrintFibonacciUsinRecursion` with the first two terms as `0` and `1`.
- Generates the first 10 Fibonacci numbers.

### Example Output
```
 1  1  2  3  5  8  13  21  34  55
```

## Key Concepts
- **Recursion:** The program leverages recursion to simplify the generation of the Fibonacci sequence.
- **Parameters in Recursion:** The method keeps track of the current and previous Fibonacci numbers through parameters, making the recursive logic clean and efficient.

## How to Run
1. Copy the code into a C# development environment (e.g., Visual Studio or Visual Studio Code).
2. Build and run the program.
3. Observe the Fibonacci series printed to the console.

## Code Listing
```csharp
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
```

## Advantages of Using Recursion
- **Readability:** Simplifies the code logic for generating Fibonacci sequences.
- **Compactness:** Reduces the need for explicit loops and variables.
