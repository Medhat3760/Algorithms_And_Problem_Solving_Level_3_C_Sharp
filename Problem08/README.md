# Problem8

This repository contains a C# program that demonstrates how to generate two 3x3 matrices filled with random numbers, multiply their corresponding elements, and display the results.

## Code Structure

### Namespace
The program resides in the `Problem8` namespace and is implemented in a single class called `Problem8`.

### Methods
The program includes the following methods:

#### 1. `RandomNumber`
This method generates a random integer within a specified range.

- **Parameters:**
  - `int from`: The lower bound (inclusive) for the random number.
  - `int to`: The upper bound (exclusive) for the random number.

- **Implementation:**
  - Uses the `Random` class to generate the random number.

```csharp
static int RandomNumber(int from, int to)
{
    return random.Next(from, to);
}
```

#### 2. `FillMatrixWithRandomNumbers`
This method populates a matrix with random numbers between 1 and 10.

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
            matrix[i, j] = RandomNumber(1, 11);
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
            Console.Write($" {matrix[i, j]:D2}   ");
        }
        Console.WriteLine();
    }
}
```

#### 4. `MultiPlyTwoMatrix`
This method multiplies corresponding elements of two matrices and stores the results in a third matrix.

- **Parameters:**
  - `int[,] matrix1`: The first input matrix.
  - `int[,] matrix2`: The second input matrix.
  - `int[,] matrixResults`: The matrix to store the resulting products.

- **Implementation:**
  - Uses nested `for` loops to traverse the matrices.
  - Multiplies corresponding elements from `matrix1` and `matrix2` and assigns the result to `matrixResults`.

```csharp
static void MultiPlyTwoMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixResults)
{
    for (short i = 0; i < matrix1.GetLength(0); i++)
    {
        for (short j = 0; j < matrix1.GetLength(1); j++)
        {
            matrixResults[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
}
```

### `Main` Method
The entry point of the program initializes three 3x3 matrices, fills the first two with random numbers, computes the element-wise product of the two matrices, and prints all three matrices.

```csharp
static void Main(string[] args)
{
    int[,] matrix1 = new int[3, 3];
    int[,] matrix2 = new int[3, 3];
    int[,] matrixResults = new int[3, 3];

    FillMatrixWithRandomNumbers(matrix1);
    FillMatrixWithRandomNumbers(matrix2);
    MultiPlyTwoMatrix(matrix1, matrix2, matrixResults);

    Console.WriteLine("\nMatrix1:");
    PrintMatrix(matrix1);

    Console.WriteLine("\nMatrix2:");
    PrintMatrix(matrix2);

    Console.WriteLine("\nResults:");
    PrintMatrix(matrixResults);
}
```

## How to Run

1. Clone this repository.
2. Open the project in an IDE that supports C#, such as Visual Studio.
3. Compile and run the program.

## Output
The program generates three matrices:
- Two 3x3 matrices filled with random numbers between 1 and 10.
- A 3x3 matrix containing the product of corresponding elements from the first two matrices.

### Example Output
```
Matrix1:
 02   05   08   
 03   07   04   
 01   06   09   

Matrix2:
 10   02   01   
 04   08   05   
 07   03   06   

Results:
 20   10   08   
 12   56   20   
 07   18   54   
```

## Purpose
This program demonstrates:
- Using multidimensional arrays in C#.
- Generating random numbers within a specified range.
- Performing element-wise operations on matrices.
- Formatting console output for readability.

