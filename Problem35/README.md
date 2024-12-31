# Problem35: Print Each Word In a String

This program takes a string as input, splits it into individual words, and prints each word on a new line. The functionality is implemented using basic string manipulation techniques in C#.

## Features

1. **Input a String**: The user is prompted to enter a string.
2. **Split String into Words**: The program splits the string based on spaces and extracts each word.
3. **Print Words**: Each extracted word is printed on a new line.

## Code Explanation

### Methods

#### `ReadString(string message)`
- Prompts the user with a message and reads the input string.
- **Parameters**:
  - `message`: A string to display as a prompt to the user.
- **Returns**: The input string entered by the user.

#### `PrintEachWordInString(string s1)`
- Splits the input string into words and prints each word on a new line.
- **Steps**:
  - Defines a delimiter (`delim`) as a space (`" "`).
  - Uses a `while` loop to repeatedly find the delimiter's position (`IndexOf`) and extract substrings (`Substring`).
  - Skips empty substrings to avoid printing unnecessary blank lines.
  - Prints each word until the string is exhausted.

#### `Main(string[] args)`
- The entry point of the program.
- Reads the user's input string using `ReadString`.
- Calls `PrintEachWordInString` to split and print each word.

## Example Usage

### Input
```
Please Enter Your String?
Abdelrahman Medhat Rushdy
```

### Output
```
Your string words are: 
Abdelrahman
Medhat
Rushdy
```

## How It Works
1. **Input Reading**:
   - The user enters a string, e.g., `"Hello world! Welcome to C# programming."`.
2. **String Splitting**:
   - The string is split into words by finding spaces (`" "`) as delimiters.
   - Each word is extracted using `Substring` and processed iteratively.
3. **Printing**:
   - Each non-empty word is printed on a new line.

## Key Concepts
- **String Manipulation**:
  - Using `IndexOf` to locate delimiters.
  - Extracting substrings with `Substring`.
- **Loops**:
  - A `while` loop is used to process the string until no delimiters remain.
- **Conditionals**:
  - Checking for non-empty substrings to avoid unnecessary output.

## Improvements and Notes
- The program currently only handles spaces as delimiters. It can be extended to handle other delimiters like commas, tabs, or multiple spaces.
- Using modern string manipulation methods (e.g., `Split` method with `StringSplitOptions.RemoveEmptyEntries`) could simplify the code.
