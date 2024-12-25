# Count Letters with Case Matching

## Overview
This C# program counts the occurrences of a specific letter in a given string. The program offers the ability to either match the letter's case or ignore it, providing flexible functionality for letter counting.

---

## Features
1. **Read a String**: Prompts the user to input a string.
2. **Read a Character**: Prompts the user to input a character to count.
3. **Invert Letter Case**: Toggles a character's case (uppercase to lowercase and vice versa).
4. **Count Specific Letters**:
   - Matches the case of the character by default.
   - Optionally ignores case when counting letters.

---

## Program Workflow

1. The user is asked to input a string.
2. The user is prompted to input a character whose occurrences they want to count.
3. The program:
   - Counts the exact matches of the character in the string.
   - Counts all matches of the character regardless of case.
4. The results are displayed to the user.

---

## Code Explanation

### 1. **`ReadString` Method**
```csharp
static string ReadString(string message)
```
- Accepts a prompt message.
- Reads and returns the user-input string.

### 2. **`ReadChar` Method**
```csharp
static char ReadChar(string message)
```
- Accepts a prompt message.
- Reads and returns the user-input character.

### 3. **`InvertLetterCase` Method**
```csharp
static char InvertLetterCase(char c)
```
- Accepts a character `c`.
- Returns the character with its case inverted (e.g., `A` -> `a` or `a` -> `A`).

### 4. **`CountSpecificLetter` Method**
```csharp
static short CountSpecificLetter(string text, char letter, bool matchCase = true)
```
- Counts the occurrences of `letter` in the `text` string.
- Accepts a boolean `matchCase`:
  - `true`: Matches the letter's case exactly.
  - `false`: Ignores the case.

### 5. **`Main` Method**
```csharp
static void Main(string[] args)
```
- Manages the program's execution flow:
  - Reads the string and character inputs from the user.
  - Counts the occurrences of the character in the string both with and without case matching.
  - Displays the results.

---

## Sample Output
### Input:
```
Please Enter Your String? Hello World

Please Enter Your Character? l
```
### Output:
```
Letter 'l' Count = 3

Letter 'l' and 'L' Count = 3
```

---

## How to Run
1. Copy the code into a `.cs` file (e.g., `Problem31.cs`).
2. Compile the file using a C# compiler, or run it in an IDE like Visual Studio.
3. Follow the prompts in the console to interact with the program.

---

## Key Learning Points
- Demonstrates string manipulation techniques.
- Highlights the use of optional parameters in methods.
- Provides a practical example of case-sensitive and case-insensitive comparisons in C#.

---

## Enhancements
- Extend the program to handle input validation.
- Add functionality to process multiple characters at once.
- Allow the user to count digits or special characters in the string.
