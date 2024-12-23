# Problem23: Print First Letter of Each Word

This C# program takes a string input from the user and prints the first letter of each word in the string. It uses simple logic to identify words based on spaces and extracts the first letter of each word.

## Features

- Prompts the user to input a string.
- Extracts and prints the first letter of each word in the string.

## How It Works

1. **Reading User Input:**
   - The `ReadString` method displays a message prompting the user to input a string. It then reads and returns the input string.

2. **Extracting First Letters:**
   - The `PrintFirstLetterOfEachWord` method iterates through the string.
   - A boolean variable `isFirstLetter` is used to track whether the current character is the start of a word.
   - If a character is not a space and `isFirstLetter` is `true`, the character is printed as the first letter of a word.
   - If a space is encountered, `isFirstLetter` is set to `true` to indicate the start of the next word.

3. **Main Method:**
   - The `Main` method orchestrates the execution by:
     - Calling `ReadString` to get the input string.
     - Passing the input string to `PrintFirstLetterOfEachWord` to process and print the result.

## Code
```csharp
﻿namespace Problem23
{
    // Print First Letter of Each Word
    internal class Problem23
    {

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();

            return text;

        }

        static void PrintFirstLetterOfEachWord(string text)
        {

            Console.WriteLine("First Letter Of Each Word:");

            bool isFirstLetter = true;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] != ' ' && isFirstLetter)
                {
                    Console.WriteLine(text[i]);
                }

                isFirstLetter = (text[i] == ' ') ? true : false;

            }

        }

        static void Main(string[] args)
        {
            PrintFirstLetterOfEachWord(ReadString("Please Enter Your String?"));
        }
    }
}
```

## Example
### Input
```
Please Enter Your String?
Hello World This Is C#
```

### Output
```
First Letter Of Each Word:
H
W
T
I
C
```

## Explanation
- The program reads the string: `Hello World This Is C#`.
- It iterates through the string, identifying the start of each word by checking for non-space characters after a space.
- Each first letter (`H`, `W`, `T`, `I`, `C`) is printed.

## Use Cases
- Extracting initials from a sentence.
- Text processing tasks where word boundaries need to be identified.

## Notes
- The program assumes words are separated by single spaces. It may not handle multiple spaces or special characters efficiently.
