# Problem41: Reverse Words in a String

## Description
This program reverses the order of words in a given string. It demonstrates how to split a string into individual words, reverse their order, and recombine them into a single output string.

---

## Features

1. **Split String into Words**:
   - The `SplitString` method extracts individual words from the input string based on a specified delimiter.

2. **Reverse Word Order**:
   - The `ReverseWordsInString` method reverses the order of the words in the string while maintaining their original form.

3. **Interactive Input**:
   - Allows users to input a string at runtime for processing.

---

## Code Structure

### Methods

1. **`ReadString(string message)`**:
   - Displays a prompt message and reads the user's input string.

2. **`SplitString(string text, string delimiter)`**:
   - Splits the input string into a list of words based on the specified delimiter.
   - Ensures no empty words are included in the resulting list.

3. **`ReverseWordsInString(string text)`**:
   - Reverses the order of the words in the input string.
   - Uses the `SplitString` method to split the input string and then concatenates the words in reverse order.

4. **`Main(string[] args)`**:
   - Entry point of the program.
   - Reads the user's input string.
   - Calls the `ReverseWordsInString` method and displays the reversed string.
