# Problem18: Intersected Numbers in Matrices

This program is designed to find and display the common numbers (intersected numbers) between two 2D matrices. It compares the elements of the two matrices and outputs the numbers that exist in both.

## Overview

The program performs the following tasks:

1. **Matrix Definition**: Initializes two 2D matrices (`matrix1` and `matrix2`) with predefined values.
2. **Printing Matrices**: Displays the matrices in a formatted grid.
3. **Finding Intersected Numbers**: Identifies numbers that exist in both matrices.
4. **Output Results**: Prints the intersected numbers to the console.

## Code Structure

### Methods

### `PrintMatrix(int[,] matrix)`
This method prints a given 2D matrix in a tabular format.

- **Input**: A 2D integer array (`matrix`)
- **Output**: Console output of the matrix
- **Logic**: Loops through the rows and columns of the matrix, formatting the output for readability.

### `IsNumberExistsInMatrix(int[,] matrix, int number)`
This method checks if a specific number exists in a given matrix.

- **Input**: A 2D integer array (`matrix`) and an integer (`number`)
- **Output**: Boolean value (`true` if the number exists, `false` otherwise)
- **Logic**: Iterates through all elements of the matrix and returns `true` if the number is found.

### `PrintMatricesIntersectedNumbers(int[,] matrix1, int[,] matrix2)`
This method finds and prints the numbers that are common to both matrices.

- **Input**: Two 2D integer arrays (`matrix1` and `matrix2`)
- **Output**: Console output of the intersected numbers
- **Logic**:
  1. Loops through all elements of `matrix1`.
  2. Checks if each number exists in `matrix2` using `IsNumberExistsInMatrix`.
  3. If a match is found, the number is printed.

### Main Method

The `Main` method drives the program:

1. **Matrix Initialization**:
   - Defines two matrices (`matrix1` and `matrix2`) with predefined values.
2. **Matrix Display**:
   - Prints both matrices using `PrintMatrix`.
3. **Intersection Calculation**:
   - Finds and displays intersected numbers using `PrintMatricesIntersectedNumbers`.

## Example Output

For the matrices:

**Matrix1:**
```
  0  77  99
  1  10  22
  1  44  33
```

**Matrix2:**
```
 30   1   9
 77  30  22
 99  44  50
```

The output will be:
```
Intersected Numbers are:

 77   99    1   22   44
```

## Key Features

- **Matrix Intersection**: Efficiently identifies and displays common numbers.
- **Reusability**: Methods like `IsNumberExistsInMatrix` and `PrintMatrix` are reusable for other matrix operations.

## How to Run

1. Copy the code into a C# development environment (e.g., Visual Studio).
2. Build and run the project.
3. View the matrices and the intersected numbers in the console output.

## Customization

- **Matrix Values**: Modify the predefined `matrix1` and `matrix2` values to test different cases.
- **Matrix Size**: Adjust the dimensions of the matrices to suit specific needs.

---

This program demonstrates basic matrix operations in C# and provides a clear example of how to compare and process data in two-dimensional arrays.

