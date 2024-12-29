# Problem34: Print All Vowels in a String

## Description
This C# program reads a string from the user, identifies all vowels within the string, and prints them to the console. It is a simple demonstration of string manipulation and the use of conditionals for character classification.

---

## How It Works
The program consists of the following key components:

### 1. **ReadString Method**
- **Purpose**: Prompts the user to enter a string and returns the input.
- **Implementation**:
  ```csharp
  static string ReadString(string message)
  {
      string s1;
      Console.WriteLine(message);
      s1 = Console.ReadLine();
      return s1;
  }
  ```

### 2. **IsVowel Method**
- **Purpose**: Determines if a given character is a vowel (`a`, `e`, `i`, `o`, or `u`).
- **Implementation**:
  ```csharp
  static bool IsVowel(char ch1)
  {
      ch1 = char.ToLower(ch1);
      return (ch1 == 'a' || ch1 == 'e' || ch1 == 'o' || ch1 == 'i' || ch1 == 'u');
  }
  ```

### 3. **PrintVowels Method**
- **Purpose**: Iterates through the characters of the input string, checks for vowels using the `IsVowel` method, and prints them.
- **Implementation**:
  ```csharp
  static void PrintVowels(string s1)
  {
      Console.Write("\nVowels in string are: ");
      for (short i = 0; i < s1.Length; i++)
      {
          if (IsVowel(s1[i]))
          {
              Console.Write(s1[i] + "  ");
          }
      }
      Console.WriteLine();
  }
  ```

### 4. **Main Method**
- **Purpose**: Entry point of the program. It:
  1. Calls `ReadString` to get input from the user.
  2. Passes the input to `PrintVowels` to display all vowels in the string.
- **Implementation**:
  ```csharp
  static void Main()
  {
      string s1 = ReadString("\nPlease Enter Your String?");
      PrintVowels(s1);
  }
  ```

---

## Example Execution
### Input:
```
Please Enter Your String?
Abdelrahman Medhat
```
### Output:
```
Vowels in string are: A  e  a  a  e  a  
```

---

## Key Features
- **Case-insensitive vowel detection**: The program handles both uppercase and lowercase vowels by converting characters to lowercase before comparison.
- **Efficient iteration**: Each character is processed exactly once to determine if it is a vowel.

---

## How to Run
1. Copy the code into a `.cs` file (e.g., `Problem34.cs`).
2. Compile the program using the C# compiler:
   ```bash
   csc Problem34.cs
   ```
3. Run the executable:
   ```bash
   Problem34.exe
   ```
4. Enter a string when prompted to see the list of vowels.

---

## Possible Enhancements
1. **Input Validation**:
   - Ensure the input is not empty.
   - Handle non-alphabetic characters more gracefully.
2. **Count Vowels**:
   - Extend the program to count the number of vowels in the string.
3. **Support Unicode**:
   - Expand the `IsVowel` method to detect vowels in other languages (e.g., accented vowels).
