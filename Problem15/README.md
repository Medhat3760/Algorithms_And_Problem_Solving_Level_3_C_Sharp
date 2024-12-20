# Problem15: Count Number in Matrix

This repository contains a C# console application that counts the occurrences of a specific number within a 2D matrix. The program demonstrates fundamental programming concepts such as arrays, loops, and user input/output operations.

---

## Features

1. **Matrix Display**:
   - Displays the contents of a 2D matrix in a readable format.

2. **Counting Occurrences**:
   - Allows the user to specify a number.
   - Counts and outputs the number of times the specified number appears in the matrix.

3. **Predefined Matrix**:
   - The program uses a predefined matrix as its data source.

---

## Code Overview

### Methods

1. **`PrintMatrix(int[,] matrix)`**
   - Accepts a 2D integer array (matrix) and prints its elements in a formatted grid.
   - Example output for the predefined matrix:
     ```plaintext
      9   0   1
      9   2   5
      1   9   9
     ```

2. **`CountNumberInMatrix(int[,] matrix, int number)`**
   - Takes the matrix and a target number as inputs.
   - Iterates through the matrix using nested loops.
   - Counts and returns the occurrences of the specified number.

3. **`PrintNumberCountInMatrix(int[,] matrix, int number)`**
   - Calls `CountNumberInMatrix` to calculate the count.
   - Outputs the count to the console.

### `Main` Method

1. **Matrix Initialization**:
   - A predefined 3x3 matrix is used as follows:
     ```csharp
     int[,] matrix = { { 9, 0, 1 }, { 9, 2, 5 }, { 1, 9, 9 } };
     ```

2. **Matrix Display**:
   - Prints the matrix using the `PrintMatrix` method.

3. **User Input**:
   - Prompts the user to enter a number they want to count in the matrix.

4. **Counting and Display**:
   - Calls `PrintNumberCountInMatrix` to count and display the number of occurrences of the entered value.

---

## How to Run

1. Open the code in an IDE such as Visual Studio.
2. Build and run the program.
3. Observe the displayed matrix.
4. Enter a number to search for when prompted.
5. View the result indicating how many times the number appears in the matrix.

---

## Example Execution

### Input
```plaintext
Matrix:
  9   0   1
  9   2   5
  1   9   9

Enter the number to count in matrix? 9
```

### Output
```plaintext
number 9 count in matrix is 4
```

---

## Key Concepts Demonstrated

1. **2D Arrays**:
   - Defining and initializing a matrix.
   - Iterating through matrix elements using nested loops.

2. **User Interaction**:
   - Reading input from the console.
   - Displaying results dynamically based on user input.

3. **Method Decomposition**:
   - Modular design with specific tasks handled by separate methods.

---

## Future Enhancements

1. Allow dynamic matrix input from the user.
2. Extend functionality to handle larger or non-square matrices.
3. Add error handling for invalid inputs.
