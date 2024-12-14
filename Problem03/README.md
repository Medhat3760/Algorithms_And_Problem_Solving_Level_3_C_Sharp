# Sum Each Row of a Matrix and Store in an Array

This C# program generates a 3x3 matrix with random integers between 1 and 99, calculates the sum of each row, and stores the sums in a one-dimensional array. It demonstrates matrix operations, random number generation, and array manipulation.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem3`
- **Class**: `Problem3`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`RandomNumber` Method**:
   - Generates a random integer within a specified range (`from` to `to`).
   - Uses the `Random` class for randomization.

2. **`FillMatrixWithRandomNumbers` Method**:
   - Populates a given matrix with random integers.
   - Iterates through each row and column to assign random values.

3. **`PrintMatrix` Method**:
   - Prints the matrix in a formatted grid.
   - Ensures numbers are aligned for better readability.

4. **`RowSum` Method**:
   - Calculates the sum of a specified row in the matrix.
   - Iterates through the columns of the given row to compute the total.

5. **`SumEachRowInMatrixInArray` Method**:
   - Computes the sum of each row in the matrix and stores the results in a one-dimensional array (`arrSum`).

6. **`PrintRowsSumArray` Method**:
   - Displays the sums of the rows stored in the array.
   - Formats the output for clarity.

7. **`Main` Method**:
   - The entry point of the program.
   - Initializes a 3x3 matrix and fills it with random values.
   - Computes row sums and stores them in an array.
   - Prints the matrix and the row sums.

---

## How It Works

1. **Matrix Initialization**:
   - A 3x3 integer matrix is created as a 2D array.
   - A one-dimensional array (`arrSum`) is initialized to store the row sums.

2. **Matrix Population**:
   - The matrix is filled with random integers between 1 and 99 using `RandomNumber`.

3. **Row Sum Calculation**:
   - The sum of each row is calculated using `RowSum` and stored in the `arrSum` array.

4. **Display**:
   - The matrix and the row sums are displayed in a formatted layout.

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
