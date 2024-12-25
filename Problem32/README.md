# Problem32: Is Vowel

This C# program checks whether a given character is a vowel (case-insensitive).

## Features

- Prompts the user to input a single character.
- Validates that the input is a valid character and not whitespace.
- Determines whether the character is a vowel (`a`, `e`, `i`, `o`, `u`, case-insensitive).
- Outputs the result, indicating whether the input character is a vowel or not.

## Program Workflow

1. **ReadChar Method**:
   - Prompts the user to enter a single character.
   - Validates the input to ensure it's a valid character and not whitespace.
   - Returns the validated character.

2. **IsVowel Method**:
   - Converts the input character to lowercase.
   - Checks if the character is one of the vowels: `a`, `e`, `i`, `o`, or `u`.
   - Returns `true` if the character is a vowel, otherwise `false`.

3. **Main Method**:
   - Calls `ReadChar` to get the user input.
   - Calls `IsVowel` to check if the character is a vowel.
   - Outputs the result to the console.

## Code Example

```csharp
static bool IsVowel(char c)
{
    c = char.ToLower(c);
    return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
}
```

## How to Run

1. Copy the code into a C# file (e.g., `Problem32.cs`).
2. Compile the file using the C# compiler:
   ```bash
   csc Problem32.cs
   ```
3. Run the compiled executable:
   ```bash
   Problem32.exe
   ```

## Sample Input and Output

### Input:
```
Please Enter Your Character?
a
```

### Output:
```
Yes: Letter 'a' is vowel.
```

### Input:
```
Please Enter Your Character?
z
```

### Output:
```
No: Letter 'z' is NOT vowel.
```

## Key Notes

- The program is case-insensitive; it treats uppercase and lowercase letters equally.
- The `ReadChar` method ensures robust input validation to prevent invalid data from causing runtime errors.
