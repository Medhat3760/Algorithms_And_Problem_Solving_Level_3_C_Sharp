# Problem39_version2: Join Strings in C#

## Description
This program demonstrates how to join a list of strings into a single string using a specified delimiter in C#. It uses a modified implementation of the `JoinString` method with a simplified approach for iterating through the list and constructing the joined string.

---

## Features
1. **JoinString**:
   - Joins a list of strings into a single string, separated by the specified delimiter.
   - Ensures no trailing delimiter in the final string by trimming the last added delimiter.

---

## Code Structure
### Methods
1. `JoinString(List<string> lString, string delim)`:
   - Accepts a list of strings (`lString`) and a delimiter (`delim`).
   - Uses a `foreach` loop to iterate through the list, appending each string followed by the delimiter.
   - Removes the trailing delimiter from the final string using `Substring`.

2. `Main(string[] args)`:
   - Entry point of the program that:
     - Initializes a sample list of strings.
     - Invokes the `JoinString` method with a delimiter.
     - Displays the joined string.
