# Problem26 - Upper/Lower All Letters of a String

This program demonstrates how to convert all letters of a given string to either uppercase or lowercase. It provides a simple way to manipulate strings using built-in C# methods.

## Features

- Reads a string input from the user.
- Converts all characters in the string to uppercase.
- Converts all characters in the string to lowercase.

## How It Works

The program consists of the following methods:

### 1. `ReadString`
- Prompts the user to enter a string.
- Returns the entered string.

### 2. `UpperAllString`
- Takes a string as input.
- Converts all characters in the string to uppercase using a loop and `char.ToUpper()`.
- Returns the transformed string.

### 3. `LowerAllString`
- Takes a string as input.
- Converts all characters in the string to lowercase using a loop and `char.ToLower()`.
- Returns the transformed string.

### 4. `Main`
- Entry point of the program.
- Reads a string from the user.
- Converts and prints the string in uppercase.
- Converts and prints the string in lowercase.

## Code Explanation

```csharp
static string ReadString(string message)
{
    string text = "";
    Console.WriteLine(message);
    text = Console.ReadLine();
    return text;
}

static string UpperAllString(string text)
{
    char[] arrChar = text.ToCharArray();

    for (int i = 0; i < arrChar.Length; i++)
    {
        arrChar[i] = char.ToUpper(arrChar[i]);
    }

    return new string(arrChar);
}

static string LowerAllString(string text)
{
    char[] arrChar = text.ToCharArray();

    for (int i = 0; i < arrChar.Length; i++)
    {
        arrChar[i] = char.ToLower(arrChar[i]);
    }

    return new string(arrChar);
}
```

## Example Execution

### Input:
```
Please Enter Your String?
Hello World
```

### Output:
```
String After Upper:
HELLO WORLD

String After Lower:
hello world
```

## How to Run

1. Copy the code into a C# console application.
2. Build and run the application.
3. Enter a string when prompted.
4. View the uppercase and lowercase conversions of your string.

## Concepts Covered

- String manipulation in C#
- Character arrays
- Looping through arrays
- Built-in methods: `char.ToUpper()` and `char.ToLower()`
