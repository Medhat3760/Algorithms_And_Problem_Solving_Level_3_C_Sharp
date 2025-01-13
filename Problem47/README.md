# Add Clients to File Program

This program allows users to add client data to a file in a structured format. It uses a combination of user input, structured data, and file writing operations to store client records persistently.

## Program Overview

### Purpose
The program enables users to add multiple client records to a file named `Clients.txt`. Each client record consists of details such as account number, PIN code, name, phone number, and account balance. The records are saved in a specific format for later retrieval.

### Key Features
- Collects client data interactively from the user.
- Formats the client data into a structured line.
- Appends the client data to a text file.
- Supports adding multiple client records in one session.

---

## Code Breakdown

### Data Structure: `stClient`
The program uses a `struct` named `stClient` to represent a client's data. It contains the following fields:
- `accountNumber`: The client's account number.
- `pinCode`: The client's PIN code.
- `name`: The client's name.
- `phone`: The client's phone number.
- `accountBalance`: The client's account balance (as a `double`).

### Core Methods

#### `ReadNewClient()`
- Purpose: Reads client data from the user interactively.
- Prompts the user to input the account number, PIN code, name, phone number, and account balance.
- Returns a `stClient` object containing the entered data.

#### `ConvertRecordToLine(stClient client, string separator = "#//#")`
- Converts a `stClient` object into a single string line, separating fields with a specified delimiter (default: `#//#`).
- Returns the formatted string.

#### `AddDataLineToFile(string fileName, string dataLine)`
- Appends a single line of data to the specified file.
- Opens the file in append mode and writes the line.

#### `AddNewClient(string fileName)`
- Combines the functionality of reading client data, formatting it, and saving it to the file.

#### `AddClients(string fileName)`
- Handles the process of adding multiple clients interactively.
- After each addition, prompts the user to decide whether to add more clients.

### `Main()` Method
- Entry point of the program.
- Calls `AddClients("Clients.txt")` to initiate the process of adding client records to the file.

---

## How to Use
1. Compile and run the program.
2. Follow the prompts to enter client details:
   - Account Number
   - PIN Code
   - Name
   - Phone
   - Account Balance
3. After adding a client, you can choose whether to add more clients by entering `Y` or `N`.
4. The program appends all client records to `Clients.txt`. Each record is stored as a single line.

---

## Example
### User Input
```
Enter Account Number? A123
Enter PIN Code? 1234
Enter Name? John Doe
Enter Phone? 555-1234
Enter Account Balance? 1500.75

Client Added Successfully, Do you want to add more clients? Y/N? Y

Enter Account Number? B456
Enter PIN Code? 5678
Enter Name? Jane Smith
Enter Phone? 555-5678
Enter Account Balance? 2000.00

Client Added Successfully, Do you want to add more clients? Y/N? N
```

### File Output (`Clients.txt`)
```
A123#//#1234#//#John Doe#//#555-1234#//#1500.75
B456#//#5678#//#Jane Smith#//#555-5678#//#2000.00
```

---

## Notes
- The program assumes valid input from the user (e.g., numeric values for account balance).
- Make sure the program has write permissions for the file location.
- The default delimiter (`#//#`) can be changed by modifying the `separator` parameter in `ConvertRecordToLine`.

---

## Improvements
- **Input Validation**: Add error handling for invalid input.
- **Encryption**: Encrypt sensitive data like PIN codes before saving.
- **File Management**: Allow the user to specify a custom file name.

---

Enjoy using the Add Clients to File program!

