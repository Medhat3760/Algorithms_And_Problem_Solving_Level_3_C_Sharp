# Sum of Each Row in a Matrix

This C# program generates a 3x3 matrix with random integers between 1 and 99, displays the matrix, and calculates the sum of each row. It demonstrates the use of matrix operations and simple arithmetic in C#.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem2`
- **Class**: `Problem2`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`RandomNumber` Method**:
   - Generates a random integer within a specified range (`from` to `to`).
   - Uses the `Random` class for randomization.

2. **`FillMatrixWithRandomNumbers` Method**:
   - Populates a given matrix with random integers.
   - Iterates through each row and column to assign random values.

3. **`PrintMatrix` Method**:
   - Prints the matrix in a grid format.
   - Numbers are aligned for better readability.

4. **`RowSum` Method**:
   - Calculates the sum of a specified row in the matrix.
   - Iterates through the columns of the given row to compute the total.

5. **`PrintEachRowSum` Method**:
   - Displays the sum of each row in the matrix.
   - Iterates through all rows and calls `RowSum` to compute the sum.

6. **`Main` Method**:
   - The entry point of the program.
   - Initializes a 3x3 matrix and fills it with random values.
   - Prints the matrix and the sum of each row.

---

## How It Works

1. **Matrix Initialization**:
   - A 3x3 integer matrix is created as a 2D array.

2. **Matrix Population**:
   - The matrix is filled with random values between 1 and 100 using `RandomNumber`.

3. **Row Sum Calculation**:
   - The sum of each row is calculated using `RowSum`.
   - Results are displayed for each row in a user-friendly format.

---

## Sample Output

### Output:
```plaintext
The following is a 3x3 random matrix:
 12   34   56  
 78   90   23  
 45   67   89  

The following is a Sum Each Row In Matrix:
 Row 1 Sum = 102
 Row 2 Sum = 191
 Row 3 Sum = 201
