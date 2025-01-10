# Problem44: Remove Punctuation from a String

This repository contains a C# program that removes punctuation from a string, leaving only non-punctuation characters such as letters, numbers, and spaces.

---

## Overview

The program processes a given string character by character, checking if each character is a punctuation mark. Punctuation characters are then excluded from the result.

---

## Features

- Removes all punctuation characters (e.g., `.`, `,`, `;`, `'`, etc.) from an input string.
- Retains spaces, letters, numbers, and other non-punctuation characters.
- Implements a simple and clear logic for character filtering using built-in C# methods.

---

## Code Description

### Method: `RemovePunctuationsFromString`

This method processes the input string to remove punctuation marks.

#### Functionality:

- Converts the input string into a character array.
- Iterates over the array and checks each character using the `char.IsPunctuation` method.
- Builds a new string by excluding punctuation characters.

#### Implementation:

```csharp
static string RemovePunctuationsFromString(string text)
{
    char[] charArr = text.ToCharArray();
    string text2 = "";

    for (short i = 0; i < charArr.Length; i++)
    {
        if (!char.IsPunctuation(charArr[i]))
        {
            text2 += charArr[i];
        }
    }

    return text2;
}
```

---

### Main Method

The `Main` method demonstrates the use of `RemovePunctuationsFromString` by:

1. Defining an example string with punctuation.
2. Calling the method to process the string.
3. Printing both the original and modified strings.

#### Implementation:

```csharp
static void Main(string[] args)
{
    string s1 = "Welcome to Jordan, Jordan is a nice country; it's amazing.";

    Console.WriteLine("\nOriginal String:\n" + s1);

    Console.WriteLine("\nPunctuation Removed:\n" + RemovePunctuationsFromString(s1));
}
```

---

## Example Execution

### Input:

```plaintext
Welcome to Jordan, Jordan is a nice country; it's amazing.
```

### Output:

```plaintext
Original String:
Welcome to Jordan, Jordan is a nice country; it's amazing.

Punctuation Removed:
Welcome to Jordan Jordan is a nice country its amazing
```

---

## How to Run

1. Clone the repository or copy the code into a new C# console application.
2. Build and run the application.
3. The program will process the predefined string and display the results.

---

## Key Concepts

- **Character Filtering:** Use of `char.IsPunctuation` to identify and exclude punctuation characters.
- **String Manipulation:** Dynamic string building by iterating over a character array.
- **C# Fundamentals:** Practical implementation of loops, conditionals, and string methods.


