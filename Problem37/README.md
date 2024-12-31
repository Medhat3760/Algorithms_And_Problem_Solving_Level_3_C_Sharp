# Problem37 - Split String

This C# program splits a string into individual words or tokens based on a specified delimiter and displays each token. It provides a way to parse and process strings effectively, breaking them into manageable pieces.

## Features
- Reads a string from the user.
- Splits the string into tokens using a specified delimiter.
- Displays the number of tokens and each individual token.

## Code Explanation

### Namespace and Class
The program resides in the `Problem37` namespace and contains the `Problem37` class.

### Methods

#### 1. `ReadString`
- **Purpose**: Reads input from the user.
- **Parameters**: A message to prompt the user.
- **Returns**: The entered string.

```csharp
static string ReadString(string message)
{
    string text;
    Console.WriteLine(message);
    text = Console.ReadLine();
    return text;
}
```

#### 2. `SplitString`
- **Purpose**: Splits the input string into a list of tokens based on a specified delimiter.
- **Parameters**:
  - `text`: The string to be split.
  - `delimiter`: The string used as a separator.
- **Returns**: A list of tokens (words).

```csharp
static List<string> SplitString(string text, string delimiter)
{
    List<string> lString = new List<string>();
    string word = "";
    short pos = 0;

    while ((pos = (short)text.IndexOf(delimiter)) != -1)
    {
        word = text.Substring(0, pos);
        if (word != "")
        {
            lString.Add(word);
        }
        text = text.Substring(pos + delimiter.Length);
    }

    if (text != "")
    {
        lString.Add(text);
    }

    return lString;
}
```

#### 3. `Main`
- **Purpose**: The entry point of the program.
- **Steps**:
  1. Reads a string from the user.
  2. Calls `SplitString` to split the string using a space (`" "`) as the delimiter.
  3. Displays the number of tokens and each token.

```csharp
static void Main(string[] args)
{
    string s1 = ReadString("Please Enter Your String?");

    List<string> lString = SplitString(s1, " ");

    Console.WriteLine("\nTokens = " + lString.Count);

    foreach (string s in lString)
    {
        Console.WriteLine(s);
    }
}
```

## How to Run
1. Compile the program using a C# compiler (e.g., Visual Studio or the `dotnet` CLI).
2. Run the executable.
3. Enter a string when prompted.
4. View the output displaying the tokens and their count.

## Example Execution
### Input
```
Please Enter Your String?
Abdelrahman Medhat Rushdy
```

### Output
```
Tokens = 3
Abdelrahman
Medhat
Rushdy
```

## Key Concepts
- **String Manipulation**: Extracting substrings and splitting strings.
- **Collections**: Using `List<T>` to store and manage tokens.
- **Loops**: Iterating over characters and tokens for processing.

## Improvements and Extensions
- Allow the user to specify the delimiter.
- Trim whitespace from tokens.
- Handle special cases, such as empty input or multiple consecutive delimiters.

