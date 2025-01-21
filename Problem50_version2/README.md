# README

## Problem50_version2: Delete Client by Account Number

This project demonstrates how to manage client data in a text file and implement the deletion of a client by their account number using C#. The code uses structured programming and efficient file handling to manage the client database.

---

### Key Features
1. **Client Management**:
   - Represents clients using a `struct` called `stClient`.
   - Includes details like account number, pin code, name, phone, account balance, and a `markForDelete` flag.

2. **File Handling**:
   - Reads client data from a file (`Clients.txt`).
   - Updates client data in memory and saves back to the file.

3. **Interactive User Input**:
   - Asks the user for the account number of the client to delete.
   - Displays client details and requests confirmation before deletion.

4. **Efficient Deletion**:
   - Clients are flagged for deletion instead of immediate removal.
   - Only clients not marked for deletion are saved back to the file.

---

### File Structure
- **Clients.txt**: A text file storing client data in the following format:
  ```
  accountNumber#//#pinCode#//#name#//#phone#//#accountBalance
  ```
- **Main Program**: The entry point of the application that handles user interaction and calls relevant methods to process data.

---

### Code Walkthrough

#### 1. **Struct Definition**
```csharp
struct stClient {
    public string accountNumber;
    public string pinCode;
    public string name;
    public string phone;
    public double accountBalance;
    public bool markForDelete;
}
```
The `stClient` struct holds all client-related details, including a boolean flag (`markForDelete`) to indicate if a client is marked for deletion.

#### 2. **Key Functions**

- **Reading Client Data from File**:
  ```csharp
  static List<stClient> LoadClientsFromFile(string fileName)
  ```
  Reads all client data from `Clients.txt` into a list of `stClient`.

- **Finding a Client**:
  ```csharp
  static bool FindClientByAccountNumber(string fileName, string accountNumber, ref stClient client)
  ```
  Searches for a client by their account number and returns their details if found.

- **Marking for Deletion**:
  ```csharp
  static void MarkClientForDeleteByAccountNumber(string accountNumber, ref List<stClient> lClients)
  ```
  Flags a client as marked for deletion in the list.

- **Saving Data Back to File**:
  ```csharp
  static void SaveClientsDataToFile(string fileName, List<stClient> lClients)
  ```
  Writes the updated client list back to `Clients.txt`, excluding clients marked for deletion.

#### 3. **Interactive Deletion**
The `DeleteClientByAccountNumber` function orchestrates the deletion process:
- Prompts the user for the account number.
- Finds and displays the client.
- Asks for confirmation to delete.
- Flags the client for deletion and saves the updated list to the file.

#### 4. **Entry Point**
```csharp
static void Main(string[] args)
{
    List<stClient> lClients = LoadClientsFromFile("Clients.txt");
    string accountNumber = ReadAccountNumber();
    DeleteClientByAccountNumber("Clients.txt", accountNumber, ref lClients);
}
```
The `Main` function initializes the client list, accepts user input, and manages the deletion process.

---

### How to Run
1. Create a text file named `Clients.txt` with sample client data in the specified format.
2. Compile and run the C# code.
3. Follow the prompts to delete a client by their account number.

---

### Sample Output
#### Input:
```
Please Enter Account Number? 12345
```
#### Output:
```
The following are the client details:

Account Number : 12345
Pin Code       : 6789
Name           : John Doe
Phone          : 1234567890
Account Balance: 5000.00

Are you sure you want to delete this client? Y/N ? Y

Client Deleted Successfully.
```
---

### Dependencies
- .NET Framework or .NET Core
- C# Compiler

---

### Notes
- Ensure that `Clients.txt` exists in the working directory.
- Handle edge cases like invalid account numbers or empty files gracefully.
- Extend functionality by adding error logging or user authentication.


