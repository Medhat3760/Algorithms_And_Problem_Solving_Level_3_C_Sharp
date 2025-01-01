# Problem38: Trim Functions in C#

## Description
This C# program provides custom implementations for trimming spaces from a string. It includes the following functionalities:
- **TrimLift**: Removes leading spaces from a string.
- **TrimRight**: Removes trailing spaces from a string.
- **Trim**: Removes both leading and trailing spaces from a string by combining `TrimLift` and `TrimRight`.

The program demonstrates these functionalities with user input.

---

## Features
1. **TrimLift**: Removes all spaces from the beginning of the string.
2. **TrimRight**: Removes all spaces from the end of the string.
3. **Trim**: Removes spaces from both ends of the string using the `TrimLift` and `TrimRight` methods.

---

## Code Structure
### Methods
1. `ReadString(string message)`: 
   - Displays a message to the user and reads a string input.

2. `TrimLift(string text)`:
   - Iterates over the string to find the first non-space character and returns the substring starting from that position.

3. `TrimRight(string text)`:
   - Iterates over the string from the end to find the last non-space character and returns the substring up to that position.

4. `Trim(string text)`:
   - Combines `TrimLift` and `TrimRight` to trim spaces from both sides of the string.

5. `Main(string[] args)`:
   - Entry point of the program that:
     - Prompts the user to input a string.
     - Demonstrates the three trim functionalities.

---

## Usage

1. **Run the program**:
   Execute the compiled program.

2. **Input**:
   Enter a string when prompted.

3. **Output**:
   The program will display:
   - The string with leading spaces removed (`TrimLift`).
   - The string with trailing spaces removed (`TrimRight`).
   - The string with spaces removed from both ends (`Trim`).
