# Problem9

This repository contains a C# program that demonstrates how to generate a 3x3 matrix filled with random numbers, and then extract and display its middle row and column.

## Code Structure

### Namespace
The program resides in the `Problem9` namespace and is implemented in a single class called `Problem9`.

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

#### 4. `PrintMiddleRowOfMatrix`
This method prints the middle row of the matrix.

- **Parameters:**
  - `int[,] matrix`: The input matrix.

- **Implementation:**
  - Calculates the middle row index using `matrix.GetLength(0) / 2`.
  - Uses a `for` loop to traverse the middle row and print its elements.

```csharp
static void PrintMiddleRowOfMatrix(int[,] matrix)
{
    Console.WriteLine("\nMiddle Row of Matrix1 is:");
    short middleRow = (short)(matrix.GetLength(0) / 2);
    for (short j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[middleRow, j]:D2}   ");
    }
    Console.WriteLine();
}
```

#### 5. `PrintMiddleColOfMatrix`
This method prints the middle column of the matrix.

- **Parameters:**
  - `int[,] matrix`: The input matrix.

- **Implementation:**
  - Calculates the middle column index using `matrix.GetLength(1) / 2`.
  - Uses a `for` loop to traverse the middle column and print its elements.

```csharp
static void PrintMiddleColOfMatrix(int[,] matrix)
{
    Console.WriteLine("\nMiddle Col of Matrix1 is:");
    short middleCol = (short)(matrix.GetLength(1) / 2);
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{matrix[i, middleCol]:D2}   ");
    }
    Console.WriteLine();
}
```

### `Main` Method
The entry point of the program initializes a 3x3 matrix, fills it with random numbers, and prints the matrix along with its middle row and column.

```csharp
static void Main(string[] args)
{
    int[,] matrix = new int[3, 3];
    FillMatrixWithRandomNumbers(matrix);

    Console.WriteLine("\nMatrix1");
    PrintMatrix(matrix);

    PrintMiddleRowOfMatrix(matrix);

    PrintMiddleColOfMatrix(matrix);
}
```

## How to Run

1. Clone this repository.
2. Open the project in an IDE that supports C#, such as Visual Studio.
3. Compile and run the program.

## Output
The program generates a 3x3 matrix, displays it, and then extracts and prints its middle row and column.

### Example Output
```
Matrix1:
 01   02   03   
 04   05   06   
 07   08   09   

Middle Row of Matrix1 is:
 04   05   06   

Middle Col of Matrix1 is:
 02   05   08   
```

## Purpose
This program demonstrates:
- Using multidimensional arrays in C#.
- Generating random numbers within a specified range.
- Extracting specific rows and columns from matrices.
- Formatting console output for readability.

