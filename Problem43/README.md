# Problem43 - Replace Words (Custom)

## Overview

This C# program provides a custom implementation for replacing words in a string. It processes the text without relying on built-in functions like `string.Replace`. Instead, it uses custom splitting, joining, and case-handling logic to achieve the functionality.

### Key Features
- **Custom Split and Join**: Splits a string into words and joins them back together.
- **Case-Insensitive or Case-Sensitive Replacement**: Allows replacing words while optionally ignoring the case.
- **Manual Lowercasing**: Implements a custom method to convert strings to lowercase without using built-in methods.

## Code Explanation

### Methods

#### `SplitString`
```csharp
static List<string> SplitString(string text, string delim)
```
Splits a given string into a list of words based on a delimiter.
- **Input**: A string (`text`) and a delimiter (`delim`).
- **Output**: A list of words (`List<string>`).

**Example**: Splitting "Welcome to Egypt" by space (`" "`) results in `["Welcome", "to", "Egypt"]`.

#### `JoinString`
```csharp
static string JoinString(List<string> lWords, string delim)
```
Joins a list of words into a single string using a specified delimiter.
- **Input**: A list of words (`lWords`) and a delimiter (`delim`).
- **Output**: A single concatenated string.

#### `LowerAllString`
```csharp
static string LowerAllString(string text)
```
Converts all characters in a string to lowercase.
- **Input**: A string (`text`).
- **Output**: The lowercase version of the input string.

#### `ReplaceWordInStringUsingSplit`
```csharp
static string ReplaceWordInStringUsingSplit(string text, string wordToReplace, string replaceTo, bool matchCase = true)
```
Replaces occurrences of a word in a string with another word, with optional case sensitivity.
- **Inputs**:
  - `text`: The original string.
  - `wordToReplace`: The word to replace.
  - `replaceTo`: The replacement word.
  - `matchCase`: Whether the replacement should be case-sensitive (default: `true`).
- **Output**: The modified string with replacements applied.

#### `Main`
```csharp
static void Main(string[] args)
```
- Demonstrates the functionality of replacing words in a string.
- **Example Execution**:
  - Original String: `"Welcome to Egypt , Egypt is a nice country"`
  - Replace "Egypt" with "USA" (case-insensitive): `"Welcome to USA , USA is a nice country"`

## Example Execution

### Input:
Original String:
```plaintext
Welcome to Egypt , Egypt is a nice country
```
Word to Replace:
```plaintext
egypt
```
Replacement:
```plaintext
USA
```

### Output:

**With Case Matching:**
```plaintext
Welcome to Egypt , Egypt is a nice country
```

**Without Case Matching:**
```plaintext
Welcome to USA , USA is a nice country
```

## How It Works
1. **Split the String**: The program breaks the input string into a list of words.
2. **Iterate and Replace**: It iterates through the words and replaces matches based on the specified criteria (case-sensitive or insensitive).
3. **Join the String**: Finally, it reassembles the string from the modified word list.

## Key Learning Points
- Custom implementation of string manipulation operations.
- Understanding of basic list and string operations in C#.
- Optional case sensitivity during string comparisons.

## Dependencies
- **C#**: No additional libraries are required; uses basic collections like `List`.

## Conclusion
This program is a demonstration of custom string manipulation techniques in C#. It highlights how to replace words in a string with or without case sensitivity using manually implemented methods.

