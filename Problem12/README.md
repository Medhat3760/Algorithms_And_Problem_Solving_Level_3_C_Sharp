# Problem 12: Check Typical Matrices

## Overview
This program determines if two matrices are "typical" by comparing their individual elements. If all corresponding elements of the two matrices are identical, the matrices are considered typical.

## Code Explanation

### Key Methods:

1. **RandomNumber(int from, int to):**
   - Generates a random number within the specified range (inclusive).

2. **FillMatrixWithRandomNumbers(int[,] matrix):**
   - Populates a given matrix with random numbers between 1 and 10.

3. **PrintMatrix(int[,] matrix):**
   - Displays the matrix in a formatted way.

4. **AreTypicalMatrices(int[,] matrix1, int[,] matrix2):**
   - Compares all elements of the two matrices. Returns `true` if all corresponding elements are equal, otherwise `false`.

5. **PrintIfMatricesAreTypicalOrNot(int[,] matrix1, int[,] matrix2):**
   - Prints whether the two matrices are typical or not based on the element-wise comparison.

### Main Method:

1. Declares two 3x3 matrices: `matrix1` and `matrix2`.
2. Fills both matrices with random numbers using `FillMatrixWithRandomNumbers`.
3. Prints both matrices to the console using `PrintMatrix`.
4. Determines and prints whether the matrices are typical using `PrintIfMatricesAreTypicalOrNot`.

## Example Output

```text
Matrix1:
 03   07   09   
 06   05   04   
 08   02   01   

Matrix2:
 03   07   09   
 06   05   04   
 08   02   01   

Yes: both matrices are typical.
```

## Notes
- "Typical" means the two matrices have identical elements in the same positions.
- Random number generation ensures varied outputs for each program execution.

