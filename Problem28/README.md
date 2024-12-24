# Problem28: Invert All Letters Case

## Overview
This C# program demonstrates how to invert the case of all letters in a given string. It converts uppercase letters to lowercase and lowercase letters to uppercase. The functionality is implemented using character manipulation methods.

---

## Features
- **Character Case Inversion**: A helper function inverts the case of a single character.
- **String Case Inversion**: The program processes a string to invert the case of all its letters.

---

## Code Explanation

### Main Logic
1. **Input String**: The program initializes a hardcoded string `"abdelrahman MEDHAT"`.
2. **Case Inversion**:
   - The function `InvertAllLettersCase` processes each character in the string.
   - If the character is uppercase, it converts it to lowercase, and vice versa.
3. **Output Results**:
   - The original string is printed.
   - The string with inverted case is printed.

---

### Functions

#### 1. `InvertCharacterCase`
- **Purpose**: Inverts the case of a single character.
- **Logic**:
  - If the character is uppercase (`char.IsUpper(ch)`), it converts it to lowercase using `char.ToLower(ch)`.
  - Otherwise, it converts it to uppercase using `char.ToUpper(ch)`.

```csharp
static char InvertCharacterCase(char ch)
{
    return char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);
}
```

#### 2. `InvertAllLettersCase`
- **Purpose**: Iterates through all characters in a string, inverting the case of each character.
- **Logic**:
  - Converts the string to a character array using `ToCharArray()`.
  - Loops through each character and inverts its case using `InvertCharacterCase`.
  - Converts the modified character array back to a string.

```csharp
static string InvertAllLettersCase(string s1)
{
    char[] arrChar = s1.ToCharArray();

    for (int i = 0; i < arrChar.Length; i++)
    {
        arrChar[i] = InvertCharacterCase(arrChar[i]);
    }

    return new string(arrChar);
}
```

---

### `Main` Method
- Initializes a hardcoded string.
- Prints the original string.
- Calls `InvertAllLettersCase` to invert the case of all letters.
- Prints the modified string.

```csharp
static void Main(string[] args)
{
    string s1 = "abdelrahman MEDHAT";

    Console.WriteLine("Your String is:");
    Console.WriteLine(s1);

    Console.WriteLine("\nString After Inverting All Letters Case:");
    s1 = InvertAllLettersCase(s1);
    Console.WriteLine(s1);
}
```

---

## Example Output
**Input String**:
```
abdelrahman MEDHAT
```

**Output**:
```
Your String is:
abdelrahman MEDHAT

String After Inverting All Letters Case:
ABDELRAHMAN medhat
```

---

## How to Run
1. Copy the code into a `.cs` file, e.g., `Problem28.cs`.
2. Compile the code using a C# compiler (e.g., `csc Problem28.cs`).
3. Run the compiled executable.

---

## Applications
- Text formatting utilities.
- User input validation.
- Case-sensitive string processing.

---

## Notes
- The program uses hardcoded input for simplicity. Modify the `Main` method to accept user input if needed.

