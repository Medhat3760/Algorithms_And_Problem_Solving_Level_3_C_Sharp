# Sum Each Column in a Matrix

This C# program calculates the sum of each column in a 3x3 matrix filled with random integers.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem4`
- **Class**: `Problem4`
  - Contains methods to generate, display, and calculate the column sums of a matrix.

### Main Components

1. **`RandomNumber` Method**:
   - Generates a random number within a specified range.

2. **`FillMatrixWithRandomNumbers` Method**:
   - Populates a 3x3 matrix with random integers between 1 and 99.

3. **`PrintMatrix` Method**:
   - Prints the matrix in a structured format.

4. **`ColSum` Method**:
   - Calculates the sum of a specified column in the matrix.

5. **`PrintEachColSum` Method**:
   - Iterates through all columns in the matrix and prints their sums.

6. **`Main` Method**:
   - The entry point of the program.
   - Creates a 3x3 matrix, fills it with random numbers, prints the matrix, and then prints the sum of each column.

---

## How It Works

1. **Matrix Generation**:
   - A 3x3 matrix is initialized and filled with random integers between 1 and 99.

2. **Column Sum Calculation**:
   - Each column's sum is calculated by iterating through its rows.

3. **Output**:
   - The matrix is printed in a formatted grid.
   - The sum of each column is displayed.

---

## Sample Output

### Example Run

#### Matrix:
```plaintext
The following is a 3x3 random matrix:
 45   67   12
 23   89   34
 56   11   78
```
#### Column Sums:
```
The following are the sum of each col in the matrix:
 Col 1 Sum = 124
 Col 2 Sum = 167
 Col 3 Sum = 124
```
