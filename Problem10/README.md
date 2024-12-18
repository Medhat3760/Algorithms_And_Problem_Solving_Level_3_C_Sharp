# Problem10

This repository contains a C# program that calculates the sum of all elements in a randomly generated 3x3 matrix.

## Code Structure

### Namespace
The program resides in the `Problem10` namespace and is implemented in a single class called `Problem10`.

### Methods
The program includes the following methods:

#### 1. `RandomNumber`
This method generates a random integer within a specified range (inclusive).

- **Parameters:**
  - `int from`: The lower bound (inclusive) for the random number.
  - `int to`: The upper bound (inclusive) for the random number.

- **Implementation:**
  - Uses the `Random` class to generate the random number.

```csharp
static int RandomNumber(int from, int to)
{
    return random.Next(from, to + 1);
}
```

#### 2. `FillMatrixWithRandomNumbers`
This method populates a matrix with random numbers between 1 and 10 (inclusive).

- **Parameters:**
  - `int[,] matrix`: The matrix to be filled.

- **Implementation:**
  - Uses nested `for` loops to traverse the matrix.
  - Assigns a random number to each element using `RandomNumber`.

```csharp
static void FillMatrixWithRandomNumbers(int[,] matrix)
{
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = RandomNumber(1, 10);
        }
    }
}
```

#### 3. `PrintMatrix`
This method prints the contents of a matrix in a formatted style.

- **Parameters:**
  - `int[,] matrix`: The matrix to be printed.

- **Implementation:**
  - Uses nested `for` loops to access each element of the matrix.
  - Displays each element with proper formatting.

```csharp
static void PrintMatrix(int[,] matrix)
{
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:D2}   ");
        }
        Console.WriteLine();
    }
}
```

#### 4. `SumOfMatrix`
This method calculates the sum of all elements in a matrix.

- **Parameters:**
  - `int[,] matrix`: The input matrix.

- **Returns:**
  - `int`: The sum of all elements in the matrix.

- **Implementation:**
  - Uses nested `for` loops to traverse the matrix and accumulate the sum of its elements.

```csharp
static int SumOfMatrix(int[,] matrix)
{
    int sum = 0;
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
    }
    return sum;
}
```

### `Main` Method
The entry point of the program initializes a 3x3 matrix, fills it with random numbers, prints the matrix, and displays the sum of its elements.

```csharp
static void Main(string[] args)
{
    int[,] matrix = new int[3, 3];
    FillMatrixWithRandomNumbers(matrix);

    Console.WriteLine("\nMatrix1:");
    PrintMatrix(matrix);

    Console.WriteLine($"\nSum of Matrix = {SumOfMatrix(matrix)}");
}
```

## How to Run

1. Clone this repository.
2. Open the project in an IDE that supports C#, such as Visual Studio.
3. Compile and run the program.

## Output
The program generates a 3x3 matrix, displays it, and calculates the sum of its elements.

### Example Output
```
Matrix1:
 01   02   03   
 04   05   06   
 07   08   09   

Sum of Matrix = 45
```

## Purpose
This program demonstrates:
- Using multidimensional arrays in C#.
- Generating random numbers within a specified range.
- Iterating through arrays to compute the sum of elements.
- Formatting console output for readability.
