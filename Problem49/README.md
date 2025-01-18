# Problem49: Find Client by Account Number

This project implements a C# console application that allows users to search for a client's details by their account number. The application reads client data from a file, searches for the specified account number, and displays the client's details if found.

## Features

1. **Input Client Account Number**: Users can input an account number to search for.
2. **File-based Client Storage**: Reads client data from a file named `Clients.txt`.
3. **Data Parsing**: Parses client information from the file into structured records.
4. **Search Functionality**: Searches for a client by their account number.
5. **Display Client Details**: Displays the details of the client if the account number exists.
6. **Error Handling**: Displays an appropriate message if the account number is not found or if the file does not exist.

## Code Overview

### Data Structures

- **`stClient`**: A structure representing client details:
  - `accountNumber`: The client’s account number.
  - `pinCode`: The client’s PIN code.
  - `name`: The client’s full name.
  - `phone`: The client’s phone number.
  - `accountBalance`: The client’s account balance.

### Key Methods

#### 1. `ReadClientAccountNumber()`
Prompts the user to input an account number and returns it as a string.

#### 2. `SplitString(string line, string separator)`
Splits a string into a list of substrings based on a specified separator.

#### 3. `ConvertLineToRecord(string line, string separator = "#//#")`
Converts a line of data from the file into an `stClient` record.

#### 4. `LoadClientsDataFromFileToList(string fileName)`
Reads all client records from the specified file and returns them as a list of `stClient` structures.

#### 5. `PrintClientCard(stClient client)`
Displays the details of a given client in a formatted card style.

#### 6. `FindClientByAccountNumber(string fileName, string accountNumber, ref stClient client)`
Searches for a client by their account number in the file. If found, the method populates the `client` reference and returns `true`; otherwise, returns `false`.

### Main Method

The `Main` method orchestrates the workflow:
1. Reads the account number from the user.
2. Searches for the account number in `Clients.txt`.
3. Displays the client’s details if found, or an error message if not found.

## File Format

The `Clients.txt` file contains client records, each on a new line, with fields separated by `#//#`:

```
AccountNumber#//#PinCode#//#Name#//#Phone#//#AccountBalance
A001#//#1234#//#John Doe#//#1234567890#//#2500.50
A002#//#5678#//#Jane Smith#//#9876543210#//#4500.75
```

## Sample Output

### Case: Client Found
```
Please Enter Account Number? A001

The following are the client details:

Account Number : A001
Pin Code       : 1234
Name           : John Doe
Phone          : 1234567890
Account Balance: 2500.5
```

### Case: Client Not Found
```
Please Enter Account Number? A999

Client with Account Number (A999) is Not Found!
```

## Error Handling

- If `Clients.txt` does not exist, the application displays:
  ```
  File Not Found
  ```
- If the account number is not found in the file, the application displays:
  ```
  Client with Account Number (<accountNumber>) is Not Found!
  ```

## How to Use

1. Ensure the `Clients.txt` file exists and is formatted correctly.
2. Run the application.
3. Input the account number when prompted.
4. View the client details or the error message.

## Dependencies

- No external libraries are required.

## Notes

- The default separator for fields in the file is `#//#`.
- Ensure the file encoding supports the format used in the application (e.g., UTF-8).

---

This project demonstrates basic file handling, string manipulation, and structured data management in C#.


