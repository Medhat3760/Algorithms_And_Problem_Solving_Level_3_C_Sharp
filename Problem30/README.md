# Problem30: Count Letter in a String

This program is a C# console application that allows the user to count the occurrences of a specific character in a given string. The program takes the string and the character as input and calculates how many times the character appears in the string.

---

## Features

- **String Input**: Users can input a string of any length.
- **Character Input**: Users provide a single character to count.
- **Count Occurrences**: The program calculates and displays the total number of occurrences of the specified character in the input string.
- **Simple Interface**: The application is designed for easy interaction through the console.

---

## Code Breakdown

### 1. `ReadString` Method

Reads a string from the user and displays a message prompt.

```csharp
static string ReadString(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}
```

### 2. `ReadChar` Method

Reads a single character from the user and displays a message prompt.

```csharp
static char ReadChar(string message)
{
    Console.WriteLine(message);
    return char.Parse(Console.ReadLine());
}
```

### 3. `CountSpecificLetter` Method

Counts the occurrences of a specific character in the given string.

```csharp
static short CountSpecificLetter(string text, char letter)
{
    short counter = 0;
    for (short i = 0; i < text.Length; i++)
    {
        if (text[i] == letter)
        {
            counter++;
        }
    }
    return counter;
}
```

### 4. `Main` Method

The entry point of the program that ties everything together.

```csharp
static void Main()
{
    string s1 = ReadString("Please Enter Your String?");

    char c1 = ReadChar("\nPlease Enter Your Character?");

    Console.WriteLine("\nLetter '" + c1 + "' Count = " + CountSpecificLetter(s1, c1));
}
```

---

## Example Usage

### Input

```
Please Enter Your String?
hello world

Please Enter Your Character?
l
```

### Output

```
Letter 'l' Count = 3
```

---

## How to Run the Program

1. Copy the code into a C# IDE or editor (e.g., Visual Studio or Visual Studio Code).
2. Build and execute the program.
3. Follow the prompts to enter a string and a character.
4. View the result in the console.

---

## Applications

- Text analysis for counting specific letters in a sentence or paragraph.
- Simple string manipulation tasks.
- Educational use for understanding loops and conditionals in C#.

---

## Possible Improvements

- **Case Insensitivity**: Modify the program to count characters regardless of their case (e.g., `A` and `a`).
- **Validation**: Ensure only valid inputs are accepted (e.g., a single character for `ReadChar`).
- **Unicode Support**: Enhance the program to support counting Unicode characters.
