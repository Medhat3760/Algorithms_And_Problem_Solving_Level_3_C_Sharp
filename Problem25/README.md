# Problem 25: Lower First Letter of Each Word

## Description
This program reads a string input from the user and converts the first letter of each word to lowercase while leaving the rest of the string unchanged. It then outputs the modified string.

---

## Features
- Reads a user-provided string.
- Converts the first letter of each word in the string to lowercase.
- Preserves the original case of the remaining characters in the string.

---

## Code Explanation

### 1. `ReadString` Method
- **Purpose**: Reads a string input from the user.
- **Parameters**: A message to prompt the user.
- **Returns**: The user-entered string.

### 2. `LowerFirstLetterOfEachWord` Method
- **Purpose**: Converts the first letter of each word in the string to lowercase.
- **Parameters**: A string input.
- **Returns**: A modified string with the first letter of each word in lowercase.
- **Logic**:
  - Iterate through each character of the string.
  - Check if the current character is the first letter of a word (preceded by a space or at the beginning).
  - Convert the character to lowercase if it is the first letter of a word.

### 3. `Main` Method
- **Purpose**: The entry point of the program.
- **Logic**:
  - Calls `ReadString` to get user input.
  - Calls `LowerFirstLetterOfEachWord` to process the string.
  - Outputs the modified string.

---

## How to Run
1. Copy the code into a C# IDE or editor (e.g., Visual Studio).
2. Build and run the program.
3. Enter a string when prompted.
4. View the output showing the modified string with the first letter of each word converted to lowercase.

---

## Sample Input and Output
### Input:
```
Please Enter Your String?
Hello World This Is A Test
```

### Output:
```
String After Conversion:
hello world this is a test
