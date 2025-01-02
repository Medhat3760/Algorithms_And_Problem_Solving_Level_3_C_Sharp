# Problem39: Join Strings in C#

## Description
This program demonstrates how to join a list of strings using a specified delimiter in C#. It includes a custom implementation of a `JoinString` method that concatenates strings from a list, separated by a user-defined delimiter.

---

## Features
1. **JoinString**:
   - Joins a list of strings into a single string using the specified delimiter.
   - Handles edge cases like the placement of the delimiter to ensure no trailing delimiter.

---

## Code Structure
### Methods
1. `JoinString(List<string> lString, string delim)`:
   - Accepts a list of strings (`lString`) and a delimiter (`delim`).
   - Iterates through the list to concatenate the strings, adding the delimiter between them.
   - Ensures no delimiter is added after the last string.

2. `Main(string[] args)`:
   - Entry point of the program that:
     - Defines a sample list of strings.
     - Calls the `JoinString` method to join the strings using a delimiter.
     - Displays the resulting joined string.
