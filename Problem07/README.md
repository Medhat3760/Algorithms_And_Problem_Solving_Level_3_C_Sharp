# Problem7

This repository contains a C# program that demonstrates how to create, print, and transpose a 3x3 matrix. The code provides methods for filling a matrix with ordered numbers, transposing it, and displaying both the original and transposed matrices.

## Code Structure

### Namespace
The program resides in the `Problem7` namespace and is implemented in a single class called `Problem7`.

### Methods
The program includes the following methods:

#### 1. `FillMatrixWithRandomNumbers`
This method populates a 3x3 integer matrix with ordered numbers starting from 1.

- **Parameters:**
  - `int[,] matrix`: The 3x3 integer matrix to be filled.

- **Implementation:**
  - Uses nested `for` loops to traverse each cell of the matrix.
  - A counter variable is incremented and assigned to each cell.

```csharp
static void FillMatrixWithRandomNumbers(int[,] matrix)
{
    short counter = 0;
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            counter++;
            matrix[i, j] = counter;
        }
    }
}
```

#### 2. `PrintMatrix`
This method prints the contents of a matrix in a formatted style.

- **Parameters:**
  - `int[,] matrix`: The matrix to be printed.

- **Implementation:**
  - Uses nested `for` loops to access each element of the matrix.
  - Displays each element with appropriate spacing for better readability.

```csharp
static void PrintMatrix(int[,] matrix)
{
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2}   ");
        }
        Console.WriteLine();
    }
}
```

#### 3. `TransposeMatrix`
This method computes the transpose of a given matrix.

- **Parameters:**
  - `int[,] matrix`: The original matrix.
  - `int[,] matrixTransposed`: The matrix to store the transposed values.

- **Implementation:**
  - Uses nested `for` loops to swap rows and columns of the original matrix.

```csharp
static void TransposeMatrix(int[,] matrix, int[,] matrixTransposed)
{
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            matrixTransposed[i, j] = matrix[j, i];
        }
    }
}
```

### `Main` Method
The entry point of the program initializes a 3x3 matrix, fills it with ordered numbers using `FillMatrixWithRandomNumbers`, prints it, computes its transpose, and prints the transposed matrix.

```csharp
static void Main(string[] args)
{
    int[,] matrix = new int[3, 3];
    int[,] matrixTransposed = new int[3, 3];

    FillMatrixWithRandomNumbers(matrix);

    Console.WriteLine("\nThe following is a 3x3 matrix:");
    PrintMatrix(matrix);

    TransposeMatrix(matrix, matrixTransposed);

    Console.WriteLine("\nThe following is the transposed matrix:");
    PrintMatrix(matrixTransposed);
}
```

## How to Run

1. Clone this repository.
2. Open the project in an IDE that supports C#, such as Visual Studio.
3. Compile and run the program.

## Output
When executed, the program generates the following output:

```
The following is a 3x3 matrix:
 1    2    3   
 4    5    6   
 7    8    9   

The following is the transposed matrix:
 1    4    7   
 2    5    8   
 3    6    9   
```

## Explanation
- The `FillMatrixWithRandomNumbers` method ensures the matrix is filled with ordered numbers for simplicity.
- The `PrintMatrix` method formats the output to display the matrix in a grid-like structure.
- The `TransposeMatrix` method swaps rows and columns to create the transposed matrix.

## Purpose
This program serves as an example of basic matrix manipulation in C# and demonstrates:
- Using multidimensional arrays.
- Iterating through arrays with nested loops.
- Computing and displaying the transpose of a matrix.
