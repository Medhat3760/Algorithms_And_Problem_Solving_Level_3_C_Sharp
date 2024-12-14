# 3x3 Random Matrix Generator

This C# program generates a 3x3 matrix filled with random integers between 1 and 99 and displays it in a formatted grid layout. It demonstrates basic matrix manipulation and random number generation in C#.

---

## Code Overview

### Namespace and Class
- **Namespace**: `Problem1`
- **Class**: `Problem1`
  - Defined as `internal`, restricting access to the same assembly.

### Main Components

1. **`RandomNumber` Method**:
   - Generates a random integer within a specified range (`from` to `to`).
   - Uses the `Random` class to ensure randomness.

2. **`FillMatrixWithRandomNumbers` Method**:
   - Populates a given 3x3 matrix (`arr`) with random integers.
   - Iterates through each row and column of the matrix and assigns a random value.

3. **`PrintMatrix` Method**:
   - Prints the matrix in a formatted grid:
     - Iterates through each row and column of the matrix.
     - Displays the numbers with uniform spacing for alignment.

4. **`Main` Method**:
   - The entry point of the program.
   - Initializes a 3x3 integer matrix.
   - Fills the matrix with random values using `FillMatrixWithRandomNumbers`.
   - Displays the matrix using `PrintMatrix`.

---

## How It Works

1. **Matrix Initialization**:
   - A 3x3 matrix is created as a 2D array of integers.

2. **Matrix Population**:
   - Each element of the matrix is assigned a random number between 1 and 99 using the `RandomNumber` method.

3. **Matrix Display**:
   - The matrix is printed row by row, with numbers formatted for alignment.

---

## Sample Output

### Output:
```plaintext
The following is a 3x3 random matrix:
 35   88   22  
 47   12   99  
 73   45   61
