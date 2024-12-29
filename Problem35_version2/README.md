# Problem35_version2: Print Each Word in a String

## Overview
This program reads a string input from the user and prints each word in the string on a new line. It achieves this by iterating through the string character by character and identifying spaces as word delimiters.

## How It Works
The program consists of three methods:

### 1. `ReadString`
- **Purpose**: Reads a string from the user.
- **Parameters**: 
  - `message`: A string prompt to display to the user.
- **Returns**: The string entered by the user.

### 2. `PrintEachWordInString`
- **Purpose**: Prints each word from the input string on a new line.
- **Parameters**: 
  - `text`: The string to process.
- **Logic**:
  - Iterates through each character in the string.
  - When a space (`' '`) is encountered, it starts a new line.
  - Otherwise, it continues printing characters on the current line.

### 3. `Main`
- **Purpose**: Serves as the program's entry point.
- **Logic**:
  - Prompts the user for a string using `ReadString`.
  - Passes the input string to `PrintEachWordInString` for processing and output.

## Example Execution

### Input:
```
Please Enter Your Text?
Abdelrahman Medhat Rushdy
```

### Output:
```
Your string words are: 
Abdelrahman
Medhat
Rushdy
```

## Key Features
- **Character-Based Parsing**: Processes the input string character by character to split words.
- **Space as Delimiter**: Uses spaces to identify word boundaries.
- **Simple Implementation**: Relies on straightforward loops and conditionals.

## Usage
1. Compile the program using any C# compiler.
2. Run the program and enter a string when prompted.
3. View the output, where each word is printed on a new line.

## Code
```csharp
namespace Problem35_version2
{
    // Print Each Word In String
    internal class Problem35_version2
    {

        static string ReadString(string message)
        {
            string text;
            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;
        }

        static void PrintEachWordInString(string text)
        {
            Console.WriteLine("\nYour string words are: ");
            for (short i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(text[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            PrintEachWordInString(ReadString("Please Enter Your Text?"));
        }
    }
}
