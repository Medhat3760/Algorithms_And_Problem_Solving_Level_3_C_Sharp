# Problem 11: Check Matrices Equality

## Overview
This program checks whether two matrices are equal based on the sum of their elements. It uses random numbers to populate two matrices and then determines if their sums are identical.

## Code Explanation

### Key Methods:

1. **RandomNumber(int from, int to):**
   - Generates a random number within the specified range (inclusive).

2. **FillMatrixWithRandomNumbers(int[,] matrix):**
   - Populates a given matrix with random numbers between 1 and 10.

3. **PrintMatrix(int[,] matrix):**
   - Displays the matrix in a formatted way.

4. **SumOfMatrix(int[,] matrix):**
   - Calculates and returns the sum of all elements in the matrix.

5. **AreEqualMatrices(int[,] matrix1, int[,] matrix2):**
   - Compares the sums of two matrices and returns `true` if they are equal, otherwise `false`.

6. **PrintMatricesAreEqualityOrNot(int[,] matrix1, int[,] matrix2):**
   - Prints whether the two matrices are equal based on their sums.

### Main Method:

1. Declares two 3x3 matrices: `matrix1` and `matrix2`.
2. Fills both matrices with random numbers using `FillMatrixWithRandomNumbers`.
3. Prints both matrices to the console using `PrintMatrix`.
4. Determines and prints whether the matrices are equal using `PrintMatricesAreEqualityOrNot`.

## Example Output

```text
Matrix1:
 05   08   02   
 09   04   07   
 03   01   06   

Matrix2:
 06   04   03   
 02   08   07   
 01   05   09   

No: matrices are NOT Equal.
```

## Notes
- Equality is determined by comparing the sums of matrix elements, not their individual elements.
- The random number generation ensures varied outputs for each program execution.

