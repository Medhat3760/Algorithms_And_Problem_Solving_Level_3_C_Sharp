# Convert Line Data to Record

This C# program demonstrates how to convert a single line of delimited string data into a structured record using a custom data structure. It extracts client information from a string, splits the data, and maps it into a `struct` for easier processing.

## Features
- Converts a delimited string into a structured `stClientData` record.
- Splits the line data based on a customizable separator.
- Prints the extracted client record in a user-friendly format.

## Code Structure

### Struct Definition

The `stClientData` struct is used to represent client information:
```csharp
struct stClientData
{
    public string accountNumber;
    public string pinCode;
    public string name;
    public string phone;
    public double accountBalance;
}
```

### Functions

#### 1. `SplitString`
Splits a string into a list of substrings based on a given separator.
```csharp
static List<string> SplitString(string text, string separator)
```
- **Parameters**:
  - `text`: The string to split.
  - `separator`: The delimiter to use for splitting.
- **Returns**: A list of substrings.

#### 2. `ConvertLineDataToRecord`
Converts a delimited string into an `stClientData` record.
```csharp
static stClientData ConvertLineDataToRecord(string lineData, string separator = "#//#")
```
- **Parameters**:
  - `lineData`: The delimited string containing client data.
  - `separator`: The delimiter used in the line data (default: `#//#`).
- **Returns**: A populated `stClientData` record.

#### 3. `PrintClientRecord`
Prints the fields of an `stClientData` record in a readable format.
```csharp
static void PrintClientRecord(stClientData clientData)
```
- **Parameters**:
  - `clientData`: The record to print.

### Main Function
The main function demonstrates the functionality:
```csharp
static void Main(string[] args)
{
    string lineData = "A150#//#1234#//#Abdelrahman Medhat#//#079999#//#5270.100000";

    Console.WriteLine("\nLine Record is:\n" + lineData);

    stClientData client = ConvertLineDataToRecord(lineData);

    PrintClientRecord(client);
}
```
- Defines a sample delimited string.
- Converts the string into a record.
- Prints the extracted client data.

## Example Output
```
Line Record is:
A150#//#1234#//#Abdelrahman Medhat#//#079999#//#5270.100000

The following is the extracted client record :

Account Number: A150
Pin Code: 1234
Name: Abdelrahman Medhat
Phone: 079999
Account Balance: 5270.1
```

## How It Works
1. The program starts with a delimited string containing client data.
2. The `SplitString` function splits the string into individual fields based on the `#//#` separator.
3. The `ConvertLineDataToRecord` function maps the fields to the `stClientData` struct.
4. The `PrintClientRecord` function displays the structured data.



