# Problem14: Scalar Matrix Checker

This program is a C# implementation to determine whether a given square matrix is a **scalar matrix**. A scalar matrix is a diagonal matrix in which all diagonal elements are equal, and all off-diagonal elements are zero.

## Features

1. **Matrix Printing**:
   - The program neatly displays the matrix using the `PrintMatrix` method.

2. **Scalar Matrix Validation**:
   - The `IsScalarMatrix` method checks:
     - If all diagonal elements are equal.
     - If all off-diagonal elements are zero.

3. **Static Matrix for Testing**:
   - A predefined matrix is tested for the scalar matrix property.

## Code Explanation

### Methods

#### 1. `PrintMatrix`
This method iterates through the 2D matrix and prints its elements in a formatted manner.

```csharp
static void PrintMatrix(int[,] matrix)
{
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j],2}   ");
        }
        Console.WriteLine();
    }
}
```

#### 2. `IsScalarMatrix`
This method checks whether the given matrix satisfies the conditions of a scalar matrix:

- **Diagonal Elements**: All diagonal elements must be identical.
- **Off-Diagonal Elements**: All non-diagonal elements must be zero.

The method uses two nested loops to traverse the matrix and verify the conditions.

```csharp
static bool IsScalarMatrix(int[,] matrix)
{
    int firstDiagElement = matrix[0, 0];

    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j && matrix[i, j] != firstDiagElement)
            {
                return false;
            }
            else if (i != j && matrix[i, j] != 0)
            {
                return false;
            }
        }
    }

    return true;
}
```

#### 3. `Main`
This is the entry point of the program. A static 3x3 matrix is defined and passed to the methods for evaluation. The program displays the matrix and outputs whether it is scalar.

```csharp
static void Main(string[] args)
{
    int[,] matrix1 =
    {
        {9, 0, 0 },
        {0, 9, 0 },
        {2, 0, 9 }
    };

    Console.WriteLine("\nMatrix1:");
    PrintMatrix(matrix1);

    if (IsScalarMatrix(matrix1))
    {
        Console.WriteLine("\nYes: matrix is scalar.");
    }
    else
    {
        Console.WriteLine("\nNo: matrix is NOT scalar");
    }
}
```

## Example Execution

### Input Matrix
The matrix tested in the program:

```
 9   0   0
 0   9   0
 2   0   9
```

### Output
```
Matrix1:
 9   0   0   
 0   9   0   
 2   0   9   

No: matrix is NOT scalar
```

### Explanation
The matrix is not scalar because the off-diagonal element `(2, 0)` has a value of `2` instead of `0`.

## Improvements and Extensions

1. **Dynamic Input**:
   - Allow users to input the matrix dimensions and elements.

2. **Multiple Matrices**:
   - Test multiple matrices in a single run for flexibility.

3. **Error Feedback**:
   - Provide specific reasons why the matrix fails the scalar condition.

4. **Refactoring**:
   - Separate logic into reusable classes for better modularity.

## Conclusion
This program effectively determines whether a matrix is scalar. It can be extended and enhanced for more versatile use cases, such as handling user inputs or testing larger datasets.


