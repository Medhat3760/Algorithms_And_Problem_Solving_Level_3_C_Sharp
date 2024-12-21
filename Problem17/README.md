# Problem 17: Check if a Number Exists in a Matrix

This C# program demonstrates how to check if a specific number exists in a matrix. It uses helper functions for matrix operations, including counting occurrences of a number and determining its presence in the matrix. The program also utilizes a custom library (`MyLib`) for reading user input.

## Code Overview

### Namespace and Libraries

```csharp
using MyLib;
namespace Problem17
```
- `MyLib`: A custom library for handling input (e.g., reading integers).
- `Problem17`: The main namespace for this program.

### Core Functions

#### `PrintMatrix`

```csharp
static void PrintMatrix(int[,] matrix)
```
Prints the matrix in a formatted manner.
- Iterates through the matrix rows and columns.
- Displays each element with proper spacing.

#### `CountNumberInMatrix`

```csharp
static short CountNumberInMatrix(int[,] matrix, int number)
```
Counts the occurrences of a specific number in the matrix.
- Loops through each element in the matrix.
- Increments a counter if the number matches the given value.

#### `IsNumberExistsInMatrix`

```csharp
static bool IsNumberExistsInMatrix(int[,] matrix, int number)
```
Checks if a number exists in the matrix by leveraging `CountNumberInMatrix`.
- Returns `true` if the count is greater than zero.
- Returns `false` otherwise.

### Main Method

```csharp
static void Main(string[] args)
```
1. **Matrix Initialization:**
   ```csharp
   int[,] matrix =
   {
       {22, 90, 11 },
       {77, 30, 99 },
       {55, 33, 44 }
   };
   ```
   - A 3x3 matrix is hardcoded with integer values.

2. **Matrix Display:**
   ```csharp
   Console.WriteLine("\nMatrix:");
   PrintMatrix(matrix);
   ```
   - The matrix is displayed using the `PrintMatrix` function.

3. **User Input:**
   ```csharp
   int number = MyInputLib.ReadIntNumber("\nPlease enter a number to look for in matrix? ");
   ```
   - Prompts the user to enter a number using the custom `MyInputLib` library.

4. **Number Existence Check:**
   ```csharp
   if (IsNumberExistsInMatrix(matrix, number))
   {
       Console.WriteLine("Yes it is there.");
   }
   else
   {
       Console.WriteLine("No it is NOT there.");
   }
   ```
   - Checks if the number exists using `IsNumberExistsInMatrix`.
   - Prints an appropriate message based on the result.

## Example Output

### Input
Matrix:
```
 22   90   11
 77   30   99
 55   33   44
```
User Input: `90`

### Output
```
Yes it is there.
```

### Input
Matrix:
```
 22   90   11
 77   30   99
 55   33   44
```
User Input: `100`

### Output
```
No it is NOT there.
```

## Key Features
- Demonstrates matrix traversal and number comparison.
- Uses modular functions for better code reuse and clarity.
- Incorporates custom input handling via `MyLib`.

## Dependencies
- **MyLib:** Ensure `MyLib` is implemented and available for handling user input, particularly the `ReadIntNumber` method.

## How to Run
1. Include the `MyLib` library in your project.
2. Compile and run the program in any C# IDE (e.g., Visual Studio).
3. Enter the desired number when prompted to check its existence in the matrix.

## Customization
- Modify the matrix initialization in `Main` to test different matrices.
- Extend functionality to read matrix values dynamically from the user or a file.

---
This program is an excellent introduction to matrix operations and modular programming in C#.

