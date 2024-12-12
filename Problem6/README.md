# Problem6

This repository contains a C# program that demonstrates how to create and manipulate a 3x3 ordered matrix. The code includes methods for filling the matrix with ordered numbers and printing its contents.

## Code Structure

### Namespace
The program resides in the `Problem6` namespace and is implemented in a single class called `Problem6`.

### Methods
The program includes the following methods:

#### 1. `FillMatrixWithOrderedNumbers`
This method populates a 3x3 integer matrix with ordered numbers starting from 1.

- **Parameters:**
  - `int[,] matrix`: The 3x3 integer matrix to be filled.

- **Implementation:**
  - Uses nested `for` loops to traverse each cell of the matrix.
  - A counter variable is incremented and assigned to each cell.

```csharp
static void FillMatrixWithOrderedNumbers(int[,] matrix)
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
This method prints the contents of the 3x3 matrix in a formatted style.

- **Parameters:**
  - `int[,] matrix`: The 3x3 integer matrix to be printed.

- **Implementation:**
  - Uses nested `for` loops to access each element of the matrix.
  - Displays each element with appropriate spacing for better readability.

```csharp
static void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("\nThe following is a 3x3 ordered matrix:");
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

### `Main` Method
The entry point of the program initializes a 3x3 matrix, fills it with ordered numbers using `FillMatrixWithOrderedNumbers`, and prints it using `PrintMatrix`.

```csharp
static void Main(string[] args)
{
    int[,] matrix = new int[3, 3];
    FillMatrixWithOrderedNumbers(matrix);
    PrintMatrix(matrix);
}
```

## How to Run

1. Clone this repository.
2. Open the project in an IDE that supports C#, such as Visual Studio.
3. Compile and run the program.

## Output
When executed, the program generates the following output:

```
The following is a 3x3 ordered matrix:
 1    2    3   
 4    5    6   
 7    8    9   
```

## Explanation
- The `FillMatrixWithOrderedNumbers` method ensures that the matrix is filled with numbers in sequential order.
- The `PrintMatrix` method formats the output to display the matrix in a grid-like structure, making it easy to visualize the elements.

## Purpose
This program serves as an example of basic matrix manipulation in C# and demonstrates:
- Using multidimensional arrays.
- Iterating through arrays with nested loops.
- Formatting console output for better readability.

