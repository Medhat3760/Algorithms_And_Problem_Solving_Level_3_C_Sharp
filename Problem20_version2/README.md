# Palindrome Matrix Checker

This C# program checks if a given matrix is a **Palindrome Matrix**. A matrix is considered a palindrome matrix if each row reads the same forward and backward.

## Features

- **Print Matrix**: Displays the matrix in a structured format.
- **Check Palindrome**: Verifies if the matrix is a palindrome matrix.

## How It Works

### Main Functionality

1. **Matrix Initialization**: The program initializes a 2D array (`matrix`) with integer values.
2. **Print Matrix**: The matrix is printed to the console using the `PrintMatrix` method.
3. **Palindrome Check**: The program checks if each row in the matrix reads the same forward and backward using the `IsPalindromeMatrix` method.
4. **Result Output**: Outputs whether the matrix is a palindrome matrix or not.

### Methods

#### `PrintMatrix(int[,] matrix)`
Prints the matrix to the console in a visually structured format.

#### `IsPalindromeMatrix(int[,] matrix)`
Checks whether the given matrix is a palindrome matrix:
- Iterates through each row.
- Compares elements from the start and end of each row, moving toward the center.
- If any mismatch is found, the matrix is not a palindrome.

## Example

### Input Matrix:
```plaintext
 1   2   1
 5   5   5
 7   3   7
```

### Output:
```plaintext
Matrix:
  1   2   1
  5   5   5
  7   3   7

Yes: Matrix is Palindrome.
```

## Code Explanation

### Initialization
The matrix is initialized with the following values:
```csharp
int[,] matrix = { { 1, 2, 1 }, { 5, 5, 5 }, { 7, 3, 7 } };
```

### Palindrome Check Logic
For each row, the program compares the first and last elements, second and second-last elements, and so on, until the center of the row is reached.

### Key Condition
```csharp
if (matrix[i, j] != matrix[i, lastColIndex - j])
{
    return false;
}
```
If any mismatch is found, the matrix is not a palindrome.

### Output Result
If all rows pass the palindrome test, the matrix is declared as a palindrome matrix.

## Usage
1. Compile and run the program in any C# environment.
2. Modify the `matrix` variable in the `Main` method to test with different matrices.

## Notes
- The program assumes the matrix is rectangular (all rows have the same number of columns).
- To extend the functionality, additional checks can be added for non-rectangular matrices.

## Example of a Non-Palindrome Matrix:

### Input Matrix:
```plaintext
 1   2   3
 4   5   6
 7   8   9
```

### Output:
```plaintext
Matrix:
  1   2   3
  4   5   6
  7   8   9

No: Matrix is NOT Palindrome.
