# Problem36: Count Each Word in a String

This C# program counts the number of words in a given string. It is implemented in the `Problem36` namespace and contains methods for reading input from the user and counting the words in a string.

## Program Overview

The program performs the following steps:

1. Prompts the user to enter a string.
2. Processes the string to count the number of words.
3. Outputs the total word count to the console.

## Code Breakdown

### `ReadString` Method
This method prompts the user with a custom message and reads a string input from the console.

```csharp
static string ReadString(string message)
{
    string text;

    Console.WriteLine(message);
    text = Console.ReadLine();

    return text;
}
```

- **Parameters**: A `message` string to display to the user.
- **Returns**: The string input provided by the user.

### `CountWords` Method
This method counts the number of words in the provided string by splitting it based on spaces.

```csharp
static short CountWords(string text)
{
    short counter = 0;

    string word = "";
    string delim = " ";
    short pos = 0;

    while ((pos = (short)text.IndexOf(delim)) != -1)
    {
        word = text.Substring(0, pos);

        if (word != "")
        {
            counter++;
        }

        text = text.Substring(pos + delim.Length);
    }

    if (text != "")
    {
        counter++;
    }

    return counter;
}
```

- **Parameters**: A `text` string to be processed.
- **Returns**: The total number of words in the string.
- **Logic**:  
  - Words are identified by spaces (" ").
  - Each word is extracted using the `Substring` method and counted.

### `Main` Method
This is the entry point of the program. It reads a string from the user, counts the words, and prints the result.

```csharp
static void Main(string[] args)
{
    string s1 = ReadString("Please Enter Your String?");

    Console.WriteLine("\nNumber Of Words: " + CountWords(s1));
}
```

- **Steps**:
  1. Calls `ReadString` to get the user’s input.
  2. Calls `CountWords` to count the number of words.
  3. Outputs the result to the console.

## Example Execution

### Input
```
Please Enter Your String?
Abdelrahman Medhat Rushdy
```

### Output
```
Number Of Words: 3
```

## How It Works

- The program identifies words by detecting spaces.
- Words are extracted using `Substring` up to the position of the first space.
- The loop continues until there are no more spaces, counting each word.
- Finally, if any text remains after the loop, it is considered a word and counted.

## Key Points

- This implementation assumes words are separated by spaces. It does not account for other delimiters (e.g., punctuation).
- The program trims empty spaces between words to avoid counting blank entries.

## Usage

1. Compile and run the program in a C# environment.
2. Enter any string when prompted.
3. View the total word count displayed in the console.

---

This program demonstrates fundamental string manipulation techniques in C# and is useful for understanding basic loops, conditionals, and input/output handling.
