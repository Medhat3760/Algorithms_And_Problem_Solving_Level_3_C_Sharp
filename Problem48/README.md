# Problem48: Show All Clients

This project demonstrates how to load client data from a file, process it into structured records, and display it in a tabular format.

## Features

- **File Parsing**: Reads client data stored in a text file.
- **Data Conversion**: Converts raw data lines into structured `stClient` records.
- **Tabular Display**: Outputs client data in a neatly formatted table.
- **Error Handling**: Checks for file existence before attempting to load data.

## Code Overview

### Struct: `stClient`
A structure used to define the attributes of a client:
- `accountNumber` (string): The client's account number.
- `pinCode` (string): The client's PIN code.
- `name` (string): The client's name.
- `phone` (string): The client's phone number.
- `accountBalance` (double): The client's account balance.

### Methods

#### 1. `SplitString(string text, string delim)`
Splits a string into a list of substrings using a specified delimiter.

#### 2. `ConvertLineDataToRecord(string dataLine, string separator)`
Converts a single line of data into an `stClient` record. Default delimiter: `#//#`.

#### 3. `LoadClientsFromFileToList(string fileName)`
Reads all client data from a file and converts it into a list of `stClient` records.
- **Input**: File name.
- **Output**: List of `stClient` objects.

#### 4. `PrintClientTableHeader()`
Prints the header row of the client table.

#### 5. `PrintClientRecord(stClient client)`
Prints a single client's data as a formatted row.

#### 6. `PrintAllClientsData(List<stClient> lClients)`
Prints all client records in a table format.

### Main Method
1. Loads client data from `Clients.txt` using `LoadClientsFromFileToList`.
2. Displays the data in a formatted table using `PrintAllClientsData`.

## How to Use

1. **Prepare the Input File**:
   - Create a text file named `Clients.txt` in the same directory as the executable.
   - Add client records in the format:
     ```
     AccountNumber#//#PinCode#//#Name#//#Phone#//#AccountBalance
     ```
     Example:
     ```
     A12345#//#4321#//#John Doe#//#555-1234#//#1000.50
     A67890#//#5678#//#Jane Smith#//#555-5678#//#2000.75
     ```

2. **Run the Program**:
   - Compile and execute the program.
   - The client data will be displayed in a formatted table.

## Sample Output

Given the file `Clients.txt` with the following contents:
```plaintext
A12345#//#4321#//#John Doe#//#555-1234#//#1000.50
A67890#//#5678#//#Jane Smith#//#555-5678#//#2000.75
```

The program outputs:
```plaintext
			Client List (2) Client(s)
___________________________________________________________________________________________________
| Accoun Number    | Pin Code   | Client Name                           | Phone       | Balance     
___________________________________________________________________________________________________
| A12345           | 4321       | John Doe                              | 555-1234    | 1000.5      
| A67890           | 5678       | Jane Smith                            | 555-5678    | 2000.75     
___________________________________________________________________________________________________
```

## Requirements
- .NET Framework or .NET Core.
- File `Clients.txt` must be present in the executable directory.

## Error Handling
- If `Clients.txt` does not exist, an error message will be displayed: `"File doesn't Exist"`.

## Notes
- Delimiters between fields must match the default separator (`#//#`).
- For large files, consider optimizing file reading and string processing.

