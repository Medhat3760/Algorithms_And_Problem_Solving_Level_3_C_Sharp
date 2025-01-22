# Update Client By Account Number (Problem51)

This C# program allows users to update the details of a client based on their account number. It reads client data from a file, updates the required client information, and saves the updated data back to the file.

## Program Overview

The program uses the following key components:

### 1. **stClient Structure**
Defines the structure of a client record with the following fields:
- `accountNumber`: Unique account number of the client.
- `pinCode`: PIN code of the account.
- `name`: Name of the client.
- `phone`: Phone number of the client.
- `accountBalance`: Balance in the account.
- `markForDelete`: Boolean indicating if the record is marked for deletion.

### 2. **Reading and Updating Data**
The program performs the following tasks:
- **Read Account Number**: Prompts the user to input the account number to update.
- **Find and Load Client Data**: Loads client records from the file (`Clients.txt`) and searches for the client by account number.
- **Update Client Data**: Updates the client record after user confirmation.
- **Save Updated Data**: Saves the modified client list back to the file.

### 3. **Key Methods**

#### Reading Data:
- `ReadAccountNumber()`: Reads the account number from the user.

#### Loading and Finding Data:
- `LoadClientsFromFile(string fileName)`: Reads and parses client records from a file into a list.
- `FindClientByAccountNumber(string fileName, string accountNumber, ref stClient client)`: Searches for a client by account number.

#### Updating and Saving Data:
- `ChangeClientRecord(string accountNumber)`: Captures updated client details from the user.
- `UpdateClientByAccountNumber(string fileName, string accountNumber, ref List<stClient> lClients)`: Updates the specified client record in memory and writes it back to the file.
- `SaveListToFile(string fileName, List<stClient> lClients)`: Saves the updated list of clients back to the file.

#### Utility Methods:
- `SplitString(string text, string delim)`: Splits a string using the specified delimiter.
- `ConvertLineToRecord(string dataLine, string separator)`: Converts a delimited string line into a `stClient` structure.
- `ConvertRecordToLine(stClient client, string separator)`: Converts a `stClient` structure into a delimited string.
- `PrintClientCard(stClient client)`: Displays the details of a client.

### 4. **Program Flow**
1. Load all clients from the file `Clients.txt` into a list.
2. Prompt the user to enter the account number.
3. Search for the client with the specified account number.
4. If found:
   - Display the client details.
   - Ask for confirmation to update.
   - If confirmed, update the details and save the changes to the file.
5. If not found, display an appropriate message.

## How to Use
1. Ensure a file named `Clients.txt` exists with client data in the format:
   ```
   accountNumber#//#pinCode#//#name#//#phone#//#accountBalance
   ```
2. Compile and run the program.
3. Enter the account number of the client to update when prompted.
4. Follow the prompts to update the client's details.
5. Confirm the changes to save the updated details.

## Example
**Input**:
```
Please Enter Account Number? 12345
The following are the client details:
Account Number : 12345
Pin Code       : 9876
Name           : John Doe
Phone          : 555-1234
Account Balance: 500.0

Are you sure you want update this client? Y/N? Y
Enter PIN Code? 1234
Enter Name? John D.
Enter Phone? 555-5678
Enter Account Balance? 1000
```

**Output**:
```
Client Updated Successfully.
```

## File Operations
- **Reading File**: The file `Clients.txt` is read to load client data into memory.
- **Writing File**: Updated client records are written back to `Clients.txt`.

## Notes
- Make sure the `Clients.txt` file exists in the same directory as the executable.
- Input validation is minimal, so ensure valid inputs for fields like `accountBalance` (numerical values).
- Handle file operations carefully to avoid data loss.

