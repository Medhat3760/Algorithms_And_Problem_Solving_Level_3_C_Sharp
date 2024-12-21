# Problem19: Find Minimum and Maximum Numbers in a Matrix

## Overview
This C# program performs matrix traversal to identify the smallest and largest numbers in a given two-dimensional integer matrix. It provides functions to:

1. Display the matrix in a tabular format.
2. Find the minimum value in the matrix.
3. Find the maximum value in the matrix.

---

## Code Features

### 1. `PrintMatrix(int[,] matrix)`
- **Purpose**: Prints the matrix in a formatted way.
- **Logic**: Iterates through each row and column of the matrix and displays its values.

```csharp
static void PrintMatrix(int[,] matrix)
```
---

### 2. `MinNumberInMatrix(int[,] matrix)`
- **Purpose**: Finds the smallest number in the matrix.
- **Logic**:
  - Initializes `min` with the first element of the matrix.
  - Iterates through all elements and updates `min` if a smaller value is found.
- **Returns**: The smallest number in the matrix.

```csharp
static int MinNumberInMatrix(int[,] matrix)
```
---

### 3. `MaxNumberInMatrix(int[,] matrix)`
- **Purpose**: Finds the largest number in the matrix.
- **Logic**:
  - Initializes `max` with the first element of the matrix.
  - Iterates through all elements and updates `max` if a larger value is found.
- **Returns**: The largest number in the matrix.

```csharp
static int MaxNumberInMatrix(int[,] matrix)
```
---

### 4. `Main(string[] args)`
- **Matrix Initialization**: Defines a 3x3 matrix with sample values:
  ```csharp
  int[,] matrix = { { 0, 10, 20 }, { -1, 20, 30 }, { 2, 30, 40 } };
  ```
- **Display**: Calls `PrintMatrix()` to display the matrix.
- **Minimum and Maximum Calculation**:
  - Calls `MinNumberInMatrix()` to find and display the smallest number.
  - Calls `MaxNumberInMatrix()` to find and display the largest number.

```csharp
static void Main(string[] args)
```

---

## Example Output
For the following matrix:
```
  0   10   20   
 -1   20   30   
  2   30   40   
```

The program will output:
```
Matrix:
  0   10   20   
 -1   20   30   
  2   30   40   

Minimum number in matrix is: -1

Maximum number in matrix is: 40
```

---

## Key Concepts

- **Matrix Traversal**: Iterating through each element of a two-dimensional array using nested loops.
- **Comparisons**: Using conditional checks to determine minimum and maximum values.
- **Modular Functions**: Code is divided into separate methods for clarity and reusability.

---

## How to Run

1. Copy the code into a C# compiler or IDE (e.g., Visual Studio).
2. Compile and execute the program.
3. Observe the matrix and the calculated minimum and maximum values in the console.

---

## Notes
- The program uses nested `for` loops to traverse the matrix row by row.
- The logic assumes that the matrix contains at least one element.
