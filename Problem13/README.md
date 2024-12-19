# Problem 13: Check Identity Matrix

This program checks whether a given matrix is an identity matrix or not. An identity matrix is a square matrix in which all the diagonal elements are 1 and all other elements are 0.

### Features
- Defines a matrix.
- Prints the matrix.
- Checks whether the matrix is an identity matrix.

### Code Explanation

#### `PrintMatrix(int[,] matrix)`
This method prints the elements of a matrix in a structured format.

- Iterates over the rows and columns of the matrix.
- Displays each element in a tabular format using `Console.Write`.

#### `IsIdentityMatrix(int[,] matrix)`
This method checks if the matrix satisfies the identity matrix conditions:

1. All diagonal elements (`matrix[i, j]` where `i == j`) must be 1.
2. All non-diagonal elements (`matrix[i, j]` where `i != j`) must be 0.

- Returns `true` if the matrix is an identity matrix; otherwise, returns `false`.

#### `Main()`
- Initializes a 3x3 matrix, `matrix1`.
- Prints the matrix using `PrintMatrix`.
- Calls `IsIdentityMatrix` to check if the matrix is an identity matrix.
- Outputs the result.

### Sample Input/Output

#### Input:
```csharp
int[,] matrix1 =
{
    { 1, 0, 0 },
    { 0, 1, 0 },
    { 0, 0, 1 }
};
```

#### Output:
```
Matrix1:
 1   0   0
 0   1   0
 0   0   1

Yes: matrix is identity.
```

#### Input:
```csharp
int[,] matrix1 =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
```

#### Output:
```
Matrix1:
 1   2   3
 4   5   6
 7   8   9

No: matrix is NOT identity.
```

### Key Points
- Identity matrices are always square.
- This program assumes the input is a valid square matrix.

### How to Run
1. Copy the `Problem13` class code into a C# console application project.
2. Run the program to check if the matrix is an identity matrix.


