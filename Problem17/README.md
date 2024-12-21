# Problem17: Number Exists In Matrix

This C# program checks if a given number exists in a matrix. The matrix is predefined in the code, and the user is prompted to enter a number to search for. The program then determines if the number is present in the matrix and displays the result.

## Code Explanation

### 1. **PrintMatrix Method**
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
- This method prints the 2D matrix in a readable format.
- The matrix is traversed row by row, and each element is printed with proper spacing.

### 2. **IsNumberExistsInMatrix Method**
```csharp
static bool IsNumberExistsInMatrix(int[,] matrix, int number)
{
    for (short i = 0; i < matrix.GetLength(0); i++)
    {
        for (short j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number) return true;
        }
    }
    return false;
}
```
- This method checks if a given number exists in the matrix.
- It iterates through every element of the matrix.
- If the number is found, it immediately returns `true`.
- If the loop completes without finding the number, it returns `false`.

### 3. **Main Method**
```csharp
static void Main(string[] args)
{
    int[,] matrix =
    {
        {22, 90, 11 },
        {77, 30, 99 },
        {55, 33, 44 }
    };

    Console.WriteLine("\nMatrix:");
    PrintMatrix(matrix);

    Console.WriteLine("\nPlease enter a number to look for in matrix? ");
    int number = int.Parse(Console.ReadLine());

    if (IsNumberExistsInMatrix(matrix, number))
    {
        Console.WriteLine("Yes it is there.");
    }
    else
    {
        Console.WriteLine("No it is NOT there.");
    }
}
```
- **Matrix Definition**:
  - A 3x3 matrix is predefined with integer values.
- **User Input**:
  - The user is prompted to enter a number to search for in the matrix.
- **Logic Execution**:
  - The `IsNumberExistsInMatrix` method is called with the matrix and the user's input.
  - Depending on the return value (`true` or `false`), the program prints whether the number exists in the matrix.

## Sample Output
### Example 1
**Input**:
```
Please enter a number to look for in matrix?
30
```
**Output**:
```
Matrix:
 22   90   11
 77   30   99
 55   33   44

Yes it is there.
```

### Example 2
**Input**:
```
Please enter a number to look for in matrix?
100
```
**Output**:
```
Matrix:
 22   90   11
 77   30   99
 55   33   44

No it is NOT there.
```

## Key Features
- **Matrix Traversal**: The program efficiently traverses the entire matrix to locate the number.
- **User Input**: Allows dynamic checking of numbers at runtime.
- **Readable Output**: Clearly displays the matrix and the results.

## Use Case
This program can be used as a basic utility for searching elements in a 2D matrix, useful in scenarios like:
- Data validation.
- Checking membership in a dataset.
- Educational purposes to understand 2D array traversal.
