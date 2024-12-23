# Problem21: Fibonacci Series

This C# program generates the Fibonacci series using a loop-based approach.

## Description
The Fibonacci series is a sequence of numbers where each number is the sum of the two preceding ones. The sequence starts with 0 and 1 by definition. This program calculates the Fibonacci series for a specified number of terms using a loop.

## Code Structure

### 1. **`PrintFibonacciUsingLoop` Method**
This method generates the Fibonacci series up to a specified number of terms.

#### Parameters:
- **`number`**: The number of terms in the Fibonacci sequence to be generated.

#### Process:
1. Initializes the first two Fibonacci numbers:
   - `prev2` (n-2) = 0
   - `prev1` (n-1) = 1
2. Prints the first Fibonacci number (1).
3. Iterates from the second term to the `number` term, computing the current Fibonacci number as:
   ```csharp
   fibNumber = prev1 + prev2;
   ```
   - Updates `prev2` to `prev1`.
   - Updates `prev1` to `fibNumber`.
4. Prints each computed Fibonacci number.

### 2. **`Main` Method**
The entry point of the program.
- Calls the `PrintFibonacciUsingLoop` method to generate and print the first 10 Fibonacci numbers.

## Example Output
When the program is executed, the output is:
```
 1 1 2 3 5 8 13 21 34 55
```
This represents the first 10 terms of the Fibonacci sequence.

## How to Use
1. Copy the code into a C# file (e.g., `Problem21.cs`).
2. Compile and run the program using a C# compiler or an IDE (like Visual Studio).
3. Modify the parameter in the `PrintFibonacciUsingLoop` method to change the number of terms generated.

## Key Concepts
- **Fibonacci Series**: A series where each number is the sum of the two preceding numbers.
- **Iterative Computation**: Uses loops for step-by-step computation instead of recursion.

## Notes
- The sequence starts at 1 in this program, but traditionally it can also start with 0 and 1. Adjustments can be made to include 0 if required.
- The time complexity of this approach is O(n), where `n` is the number of terms in the sequence.

