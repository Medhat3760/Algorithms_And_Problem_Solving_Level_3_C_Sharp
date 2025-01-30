# Banking System

This is a simple console-based Banking System developed in C# that allows users to manage client records stored in a text file. The application provides functionalities such as listing clients, adding new clients, deleting clients, updating client information, and searching for clients by account number.

## Features

- **List Clients**: Display all clients stored in the file.
- **Add New Client**: Add new client details to the system.
- **Delete Client**: Remove a client by account number.
- **Update Client**: Modify client details.
- **Find Client**: Search for a client using the account number.
- **Exit**: Terminate the application.

## How It Works

The application stores client information in a text file named `Clients.txt`, where each client's details are separated by the delimiter `#//#`. The stored details include:

- Account Number
- PIN Code
- Name
- Phone Number
- Account Balance

The program reads and writes client records to this file, ensuring data persistence.

## Program Structure

### 1. **Struct: ****`stClient`**

A struct is used to represent a client with attributes:

```csharp
struct stClient
{
    public string accountNumber;
    public string pinCode;
    public string name;
    public string phone;
    public double accountBalance;
    public bool markForDelete;
}
```

### 2. **Main Menu Options (Enum: ****`enMainMenuOptions`****)**

Defines menu options for the application:

```csharp
enum enMainMenuOptions { eListClients = 1, eAddNewClient, eDeleteClient, eUpdateClient, eFindClient, eExit }
```

### 3. **File Operations**

- `LoadClientsDataFromFile(string fileName)`: Reads and loads client records from `Clients.txt`.
- `SaveClientListToFile(string fileName, List<stClient> lClients)`: Writes client data to `Clients.txt`.

### 4. **Core Functionalities**

- `ShowClientList(string fileName)`: Displays all clients in tabular format.
- `AddNewClients(string fileName)`: Allows adding multiple clients.
- `DeleteClientByAccountNumber(string fileName, string accountNumber, ref List<stClient> lClients)`: Deletes a specific client.
- `UpdateClientByAccountNumber(string fileName, string accountNumber, ref List<stClient> lClients)`: Updates client details.
- `ShowFindClientScreen(string fileName)`: Searches for a client.

### 5. **User Interaction**

- `ReadAccountNumber()`: Prompts user for an account number.
- `PrintClientCard(stClient client)`: Displays client details in a formatted way.
- `ReadMainMenuOption()`: Captures user's choice for main menu actions.

### 6. **Main Program Execution**

```csharp
static void Main(string[] args)
{
    string fileName = "Clients.txt";
    ShowMainMenuScreen(fileName);
    Console.ReadKey();
}
```

## How to Run the Program

1. Open a C# development environment (e.g., Visual Studio, .NET CLI).
2. Create a new C# Console Application.
3. Copy and paste the provided C# code into the `Program.cs` file.
4. Ensure a text file named `Clients.txt` exists in the application directory.
5. Build and run the application.

## Future Improvements

- Add authentication for security.
- Implement a database instead of a text file for data storage.
- Create a graphical user interface (GUI).
- Enhance error handling and validation.

##


