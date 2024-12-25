# Problem29: Count Small/Capital Letters

This C# program is designed to analyze a string input and count the total number of:

- Capital (uppercase) letters
- Small (lowercase) letters
- Total characters (length of the string)

It demonstrates two approaches to perform these tasks: directly using loops and through a generic enumeration.

---

## Features

### 1. **ReadString**
- Reads a string from the user.
- Displays a custom message prompt.

```csharp
static string ReadString(string message)
```

### 2. **CountLetters**
- Counts letters based on the selected type:
  - `capitalLetters`: Counts uppercase letters.
  - `smallLetter`: Counts lowercase letters.
  - `All`: Counts all characters (string length).

```csharp
static short CountLetters(string text, enWhatToCount whatToCount = enWhatToCount.All)
```

### 3. **CountCapitalLetters**
- Counts the number of uppercase letters in a string using a loop.

```csharp
static short CountCapitalLetters(string text)
```

### 4. **CountSmallLetters**
- Counts the number of lowercase letters in a string using a loop.

```csharp
static short CountSmallLetters(string text)
```

### 5. **Enum: enWhatToCount**
- Enumeration to specify the type of counting:
  - `capitalLetters`
  - `smallLetter`
  - `All`

---

## How It Works

### Input
The program prompts the user to input a string using:
```csharp
string s1 = ReadString("Please Enter Your String?");
```

### Output
The program outputs:
1. Length of the string.
2. Count of uppercase letters.
3. Count of lowercase letters.

Example Output:
```
Please Enter Your String?
Hello World!

String Length = 12
Capital Letter Count = 2
Small Letter Count = 8

Method 2:
String Length = 12
Capital Letter Count = 2
Small Letter Count = 8
```

---

## Code Breakdown

### Method 1: Direct Loop Counting
The program uses loops to iterate through each character and check:
- If it's an uppercase letter using `char.IsUpper()`
- If it's a lowercase letter using `char.IsLower()`

Example:
```csharp
for (short i = 0; i < text.Length; i++)
{
    if (char.IsUpper(text[i]))
        count++;
}
```

### Method 2: Using `CountLetters` with `enWhatToCount`
A flexible approach that uses a `switch` statement to decide what type of counting to perform:
- `capitalLetters`: Counts uppercase letters.
- `smallLetter`: Counts lowercase letters.
- `All`: Returns the total length of the string.

---

## How to Run
1. Copy the code into a C# IDE (e.g., Visual Studio).
2. Build and run the program.
3. Enter a string when prompted.

---

## Example Use Case
### Input:
```
Hello, World!
```
### Output:
```
String Length = 13
Capital Letter Count = 2
Small Letter Count = 8

Method 2:
String Length = 13
Capital Letter Count = 2
Small Letter Count = 8
```

---

## Learning Points
- Using `char.IsUpper()` and `char.IsLower()` for character case checking.
- Leveraging `enum` to simplify and generalize method behavior.
- Iterating through strings using loops for custom logic.

---

## Notes
- The program does not account for non-alphabetic characters when counting specific letter cases.
- Enhancements could include filtering out spaces or special characters in the counts.

