# Problem24: Uppercase First Letter of Each Word

This program transforms the first letter of each word in a given string to uppercase while keeping the remaining letters unchanged. It takes user input and outputs the modified string.

## Features

- Reads a string input from the user.
- Converts the first character of each word to uppercase.
- Handles spaces effectively to identify word boundaries.

## Code Explanation

### Functions

#### `ReadString(string message)`
- **Purpose**: Prompts the user to enter a string and returns the input.
- **Parameters**: 
  - `message`: A string message to display to the user.
- **Return Value**: The user-input string.

#### `UpperFirstLetterOfEachWord(string text)`
- **Purpose**: Converts the first letter of each word in the string to uppercase.
- **Parameters**: 
  - `text`: The string to process.
- **Logic**:
  - Converts the input string to a character array for easy manipulation.
  - Iterates through the character array and identifies the first letter of each word by checking the preceding character.
  - Converts the first letter of each word to uppercase using `char.ToUpper`.
  - Reassembles the character array into a string.
- **Return Value**: The modified string with each word's first letter in uppercase.

### Main Method

#### `Main(string[] args)`
1. Prompts the user to enter a string using `ReadString`.
2. Processes the input string using `UpperFirstLetterOfEachWord`.
3. Outputs the transformed string.

## How It Works
1. The program begins by asking the user to input a string.
2. The string is passed to `UpperFirstLetterOfEachWord`, which processes and transforms it.
3. The transformed string is displayed in the console.

## Example Execution

### Input:
```
Please Enter Your String?
i love programming in c#.
```

### Output:
```
String After Conversion:
I Love Programming In C#.
```

## Instructions

1. Compile the program using any C# compiler or IDE (e.g., Visual Studio).
2. Run the program.
3. Enter a string when prompted.
4. View the output with each word's first letter capitalized.

## Concepts Covered

- String Manipulation
- Character Array (`char[]`) Usage
- Iterative Character Processing
- Use of `char.ToUpper` for Case Conversion
