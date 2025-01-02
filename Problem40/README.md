# Problem40: Join Strings with Overloading in C#

## Description
This program demonstrates how to join strings from different data structures (a `List<string>` and a `string[]`) using method overloading in C#. The program provides two overloaded `JoinString` methods to handle lists and arrays, concatenating their elements with a specified delimiter.

---

## Features
1. **Overloaded `JoinString` Method**:
   - **Version 1**: Accepts a `List<string>` and a delimiter to join its elements.
   - **Version 2**: Accepts a `string[]` array and a delimiter to join its elements.
   - Both versions ensure no trailing delimiter in the final string.

2. **Polymorphism through Overloading**:
   - Provides flexibility to handle different input types while maintaining consistent functionality.

---

## Code Structure

### Methods
1. `JoinString(List<string> lString, string delim)`:
   - Joins the elements of a `List<string>` into a single string separated by the specified delimiter.
   - Trims the trailing delimiter for a clean output.

2. `JoinString(string[] arrString, string delim)`:
   - Joins the elements of a `string[]` array into a single string, separated by the specified delimiter.
   - Similar functionality as the first overload but tailored for arrays.

3. `Main(string[] args)`:
   - Entry point of the program that:
     - Initializes a sample `List<string>` and `string[]` array.
     - Invokes the appropriate `JoinString` method for each data type.
     - Displays the joined strings.
