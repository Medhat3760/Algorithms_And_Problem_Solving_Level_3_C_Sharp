# Problem42_version2: Replace Words in a String

## Description
This program replaces all occurrences of a specific word in a string with another word using built-in string manipulation functions. It demonstrates efficient word replacement using methods such as `IndexOf`, `Remove`, and `Insert`.

---

## Features

1. **Word Replacement**:
   - Replaces all occurrences of a target word in the input string with a specified replacement word.

2. **Interactive Replacement**:
   - The replacement operation is implemented using a combination of string manipulation methods.

3. **Built-in Alternative**:
   - The program also showcases the possibility of using the built-in `Replace` function (commented for comparison).

---

## Code Structure

### Methods

1. **`ReplaceWordInStringUsingBuiltInFunction(string text, string word, string replaceTo)`**:
   - Finds all occurrences of the target word in the string.
   - Replaces each occurrence using a combination of `Remove` and `Insert` methods.
   - Iteratively searches for the next occurrence using `IndexOf` until all instances are replaced.

2. **`Main(string[] args)`**:
   - Entry point of the program.
   - Demonstrates word replacement on a predefined input string.

---

## Usage

### Steps to Execute
1. **Run the program**:
   Compile and execute the program.

2. **Input**:
   - The program uses a predefined string for demonstration:
     ```
     "Welcome to Egypt , Egypt is a nice country"
     ```

3. **Output**:
   - The program replaces occurrences of the word `"Egypt"` with `"USA"` and displays the updated string.
## Example

### Predefined Input:

