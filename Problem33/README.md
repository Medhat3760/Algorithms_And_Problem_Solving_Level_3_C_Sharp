# Problem33: Count Vowels

This C# program is designed to count the number of vowels in a given string. It leverages basic string manipulation and character checking to achieve this functionality.

## Features
- Reads a string from the user.
- Determines if each character in the string is a vowel.
- Counts and displays the total number of vowels in the input string.

## How It Works

### Main Components

1. **`ReadString` Method**
   - Prompts the user to input a string.
   - Returns the input string.

2. **`IsVowel` Method**
   - Takes a character as input.
   - Checks if the character is one of the five vowels (`a, e, i, o, u`), case-insensitively.
   - Returns `true` if the character is a vowel; otherwise, returns `false`.

3. **`CountVowels` Method**
   - Takes a string as input.
   - Iterates through each character of the string.
   - Uses the `IsVowel` method to check if the character is a vowel.
   - Maintains a counter to keep track of the number of vowels.
   - Returns the total count of vowels.

### Execution Flow
1. The program starts by calling the `ReadString` method to get a user-input string.
2. The `CountVowels` method is called to process the string and count its vowels.
3. The result is printed to the console.

## Code
```csharp
﻿namespace Problem33
{
    // Count Vowels
    internal class Problem33
    {
        static string ReadString(string message)
        {
            string text = "";
            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;
        }

        static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }

        static short CountVowels(string text)
        {
            short counter = 0;
            for (short i = 0; i < text.Length; i++)
            {
                if (IsVowel(text[i]))
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            string s1 = ReadString("Please Enter Your String?");
            Console.WriteLine("\nNumber Of Vowels is: " + CountVowels(s1));
        }
    }
}
```

## Example
**Input:**  
```
Please Enter Your String? Hello World
```

**Output:**  
```
Number Of Vowels is: 3
```

## How to Run
1. Copy the code into a C# file (e.g., `Problem33.cs`).
2. Compile and execute the program using a C# compiler or an IDE like Visual Studio.
3. Input a string when prompted, and view the result.

## Key Concepts
- **String Manipulation:** Iterating through each character in a string.
- **Character Classification:** Using conditions to classify characters as vowels.
- **Case Insensitivity:** Converting characters to lowercase before comparison.

## Applications
- Text processing and analysis.
- Identifying and counting specific patterns in strings.

---
This program demonstrates fundamental concepts of C# programming, including methods, loops, and conditional logic.
