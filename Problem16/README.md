# Problem16: Check Sparse Matrix

This C# program determines whether a given matrix is a **sparse matrix**. A sparse matrix is defined as a matrix in which the majority of its elements are zeros. Specifically, a matrix is sparse if at least half of its elements are zeros.

## Code Breakdown

### 1. **PrintMatrix Method**

This method prints the matrix in a structured, readable format.

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

- **Input**: A 2D matrix.
- **Output**: A formatted printout of the matrix to the console.

---

### 2. **CountNumberInMatrix Method**

This method counts the occurrences of a specific number in the matrix.

```csharp
static short CountNumberInMatrix(int[,] matrix, int number)
{
    short numberCount = 0;
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            if (number == matrix[i, j]) numberCount++;
        }
    }
    return numberCount;
}
```

- **Input**:
  - `matrix`: A 2D array.
  - `number`: The number to count.
- **Output**: The count of occurrences of the specified number in the matrix.

---

### 3. **IsSparseMatrix Method**

This method checks if the matrix is sparse by determining whether the number of zeros is at least half the total elements in the matrix.

```csharp
static bool IsSparseMatrix(int[,] matrix)
{
    float matrixSize = matrix.GetLength(0) * matrix.GetLength(1);
    return CountNumberInMatrix(matrix, 0) >= (matrixSize / 2);
}
```

- **Logic**:
  1. Calculate the total number of elements in the matrix (`matrixSize`).
  2. Count the number of zeros in the matrix using `CountNumberInMatrix`.
  3. Check if the count of zeros is greater than or equal to half of `matrixSize`.
- **Output**: `true` if the matrix is sparse; otherwise, `false`.

---

### 4. **Main Method**

The entry point of the program where the matrix is defined, analyzed, and the result is displayed.

```csharp
static void Main(string[] args)
{
    // Example matrix
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

- **Input**: Hardcoded matrix values.
- **Output**:
  - Prints the matrix.
  - Displays whether the matrix is sparse or not.

---

## Example Execution

### Input:
```text
Matrix:
  0   0   1
  0   0   2
  0   0  12
```

### Output:
```text
Yes: matrix is sparse.
```

### Explanation:
The given matrix has 9 elements in total. Out of these, 6 elements are zeros, which is more than half (4.5). Hence, it is a sparse matrix.

---

## How to Run the Program

1. Copy the code into a `.cs` file (e.g., `Problem16.cs`).
2. Compile and run the program using a C# compiler or an IDE like Visual Studio.
3. Observe the result indicating whether the matrix is sparse.

---

## Key Concepts Demonstrated

- **Matrix Operations**: Working with 2D arrays to perform mathematical and logical checks.
- **Method Decomposition**: Modular design of functionality for clarity and reusability.
- **Sparse Matrix Check**: A fundamental concept in numerical computation and optimization.


