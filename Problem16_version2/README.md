# Problem16_version2: Check Sparse Matrix

This program determines if a given matrix is a sparse matrix. A sparse matrix is a matrix in which the number of zero elements is greater than or equal to half of its total elements.

## Features

1. **Matrix Printing:**
   - The program neatly prints the matrix in a formatted manner for easy visualization.

2. **Sparse Matrix Validation:**
   - The program checks whether the matrix qualifies as sparse by counting the number of zeros and comparing it to half of the total number of elements.

## Code Explanation

### 1. **PrintMatrix Method**
   - Prints the matrix in a tabular format.
   - Iterates through the rows and columns of the matrix to display each element.

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

### 2. **IsSparseMatrix Method**
   - Determines whether the matrix is sparse by counting the number of zeros.
   - If the count of zeros reaches half of the total elements during the iteration, it immediately returns `true`.

#### Key Steps:
1. Calculate the total number of elements in the matrix.
2. Initialize a counter for zeros (`zeroCount`).
3. Iterate through the matrix elements, incrementing `zeroCount` for every zero encountered.
4. Return `true` if `zeroCount` meets or exceeds half of the total elements; otherwise, return `false`.

```csharp
static bool IsSparseMatrix(int[,] matrix)
{
    float totalElements = matrix.GetLength(0) * matrix.GetLength(1);
    short zeroCount = 0;

    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0)
            {
                zeroCount++;
                if (zeroCount >= (totalElements / 2))
                    return true;
            }
        }
    }

    return false;
}
```

### 3. **Main Method**
   - Defines a sample matrix and invokes the `PrintMatrix` and `IsSparseMatrix` methods.
   - Prints whether the matrix is sparse.

#### Sample Matrix:
```csharp
int[,] matrix = { { 0, 0, 1 }, { 0, 0, 2 }, { 0, 0, 12 } };
```

#### Execution Flow:
1. Print the matrix.
2. Check if the matrix is sparse.
3. Display the result.

```csharp
static void Main(string[] args)
{
    int[,] matrix = { { 0, 0, 1 }, { 0, 0, 2 }, { 0, 0, 12 } };

    Console.WriteLine("\nMatrix:");
    PrintMatrix(matrix);

    if (IsSparseMatrix(matrix))
    {
        Console.WriteLine("\nYes: matrix is sparse.");
    }
    else
    {
        Console.WriteLine("\nNo: matrix is NOT sparse.");
    }
}
```

## Example Output
### Input Matrix:
```
Matrix:
 0    0    1   
 0    0    2   
 0    0   12   
```

### Output:
```
Yes: matrix is sparse.
```

## How It Works
- **Sparse Definition:** A matrix is sparse if zero elements are ≥ 50% of the total elements.
- **Efficient Zero Check:** The loop exits early once enough zeros are found, making it efficient for large matrices.

## Usage
- Replace the `matrix` variable in the `Main` method with any other 2D array to check if it's sparse.

## Applications
- Sparse matrices are widely used in scientific computing, machine learning, and data compression due to their space-efficient properties.
