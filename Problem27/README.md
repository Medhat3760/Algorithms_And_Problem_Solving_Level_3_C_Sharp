# Problem27: Invert Character Case

This C# program demonstrates how to invert the case of a single character entered by the user. If the input character is uppercase, it will be converted to lowercase, and vice versa.

## Program Structure

### 1. `ReadCharacter`
This method reads a single character from the user input and returns it.

#### Parameters:
- `message` (string): A prompt message displayed to the user.

#### Returns:
- `char`: The character entered by the user.

### 2. `InvertCharacterCase`
This method takes a character as input and inverts its case.

#### Parameters:
- `c` (char): The character whose case needs to be inverted.

#### Returns:
- `char`: The character with its case inverted.

#### Logic:
- If the input character is uppercase, it is converted to lowercase using `char.ToLower`.
- If the input character is lowercase, it is converted to uppercase using `char.ToUpper`.

### 3. `Main`
The entry point of the program. It performs the following actions:
1. Prompts the user to enter a character.
2. Calls `ReadCharacter` to get the input.
3. Calls `InvertCharacterCase` to invert the character's case.
4. Displays the resulting character.

## How to Use
1. Run the program.
2. Enter a single character when prompted.
3. View the character with its case inverted.

## Example
**Input:**
```
Please Enter a Character?
A
```

**Output:**
```
Character After Inverting Case:
a
```

**Input:**
```
Please Enter a Character?
z
```

**Output:**
```
Character After Inverting Case:
Z
```

## Code Explanation
This program demonstrates:
- Reading and parsing user input.
- Using `char.IsUpper` and `char.ToLower`/`char.ToUpper` methods to manipulate character cases.
- Basic console input/output in C#.

## Notes
- The program assumes valid input and does not handle invalid cases such as entering multiple characters or non-alphabetical characters.

