# Problem50: Delete Client By Account Number

This C# console application is designed to manage client data stored in a text file. The program allows the user to delete a specific client record based on the account number provided. It reads the data from a file, searches for the client, confirms deletion, and updates the file.

## Features

1. **Load Clients from File**: Reads all client records from a file into memory.
2. **Find Client by Account Number**: Searches for a specific client using the account number.
3. **Print Client Details**: Displays the client's information before confirming deletion.
4. **Delete Client Record**: Removes the client's record from the file if the user confirms.
5. **Save Updated Data**: Saves the modified data back to the file.

## How It Works

1. **Input**:
   - The user is prompted to input the account number of the client they wish to delete.

2. **Processing**:
   - The program checks if the client exists in the file.
   - If found, the client's details are displayed, and the user is asked for confirmation.
   - If the user confirms, the client's record is removed from the file.

3. **Output**:
   - Displays a success message if the client is deleted.
   - Displays an error message if the client is not found.

## Code Explanation

### Struct: `stClient`
Defines the structure for a client record with the following fields:
- `accountNumber`
- `pinCode`
- `name`
- `phone`
- `accountBalance`

### Methods

#### 1. `ReadClientAccountNumber()`
Prompts the user to enter an account number.

#### 2. `SplitString(string text, string delim)`
Splits a string into parts based on a specified delimiter.

#### 3. `ConvertLineToRecord(string line, string separator = "#//#")`
Converts a line of text into a `stClient` object.

#### 4. `LoadClientsFromFileToList(string fileName)`
Loads all client records from a specified file into a list of `stClient` objects.

#### 5. `FindClientByAccountNumber(string fileName, string accountNumber, ref stClient client)`
Searches for a client by account number. If found, stores the client in the `ref` parameter and returns `true`.

#### 6. `PrintClientCard(stClient client)`
Displays the details of a client in a readable format.

#### 7. `ConvertRecordToLine(stClient client, string separator = "#//#")`
Converts a `stClient` object into a string representation for file storage.

#### 8. `LoadDataFromFileToList(string fileName)`
Reads the contents of a file into a list of strings.

#### 9. `SaveListToFile(string fileName, List<string> lFileContent)`
Writes a list of strings to a file, overwriting the existing content.

#### 10. `DeleteRecordFromFile(string fileName, string record)`
Removes a specific record from the file.

#### 11. `DeleteClientByAccountNumber(string fileName, string accountNumber)`
Coordinates the deletion process:
- Finds the client by account number.
- Confirms deletion with the user.
- Removes the client's record if confirmed.

#### 12. `Main(string[] args)`
Entry point for the program. Prompts the user for an account number and deletes the corresponding client.

## File Format
The client data file (`Clients.txt`) should have records in the following format:
```
AccountNumber#//#PinCode#//#Name#//#Phone#//#AccountBalance
```

## Example Usage

### Input
```
Please Enter Account Number? A150
```

### Output
If the account exists:
```
The following are the client details:
Account Number : A150
Pin Code       : 1234
Name           : John Doe
Phone          : 079999
Account Balance: 5270.10

Are you sure you want to delete this client? Y/N ? Y

Client Deleted Successfully.
```

If the account does not exist:
```
Client with Account Number (A150) is Not Found!
```

## How to Run
1. Place the `Clients.txt` file in the same directory as the executable.
2. Build and run the program.
3. Follow the prompts to delete a client by account number.

## Requirements
- .NET Framework or .NET Core
- A text file (`Clients.txt`) with client records

## Notes
- Ensure that the `Clients.txt` file exists before running the program.
- Use the correct account number format to avoid errors.

