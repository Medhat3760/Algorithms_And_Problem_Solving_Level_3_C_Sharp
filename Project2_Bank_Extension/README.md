# Bank Management System - C# Console Application

## Overview

This C# console application is a **Bank Management System** that allows users to manage client data and perform basic banking operations. The application is menu-driven and uses a text file (`Clients.txt`) to store client information persistently. It provides functionalities such as adding, deleting, updating, and finding clients, as well as performing transactions like deposits and withdrawals.

---

## Features

### 1. **Client Management**
   - **List Clients**: Displays all clients stored in the system.
   - **Add New Client**: Allows the user to add a new client with details such as account number, PIN code, name, phone, and account balance.
   - **Delete Client**: Enables the user to delete a client by their account number.
   - **Update Client**: Allows the user to update a client's information (PIN code, name, phone, and balance).
   - **Find Client**: Searches for a client by their account number and displays their details.

### 2. **Transactions**
   - **Deposit**: Allows the user to deposit money into a client's account.
   - **Withdraw**: Enables the user to withdraw money from a client's account (with validation to ensure the withdrawal amount does not exceed the balance).
   - **Total Balances**: Displays the total balance of all clients in the system.

### 3. **File-Based Data Storage**
   - The application uses a text file (`Clients.txt`) to store client data.
   - Each client's data is stored in a structured format, separated by a delimiter (`#//#`).

### 4. **User-Friendly Interface**
   - The application provides a clear and intuitive menu-driven interface for users to interact with the system.

---

## Code Structure

### 1. **Data Structures**
   - **`stClient` Struct**: Represents a client with the following fields:
     - `accountNumber`: Unique identifier for the client.
     - `pinCode`: PIN code for the client's account.
     - `name`: Full name of the client.
     - `phone`: Phone number of the client.
     - `accountBalance`: Current balance in the client's account.
     - `markForDelete`: Boolean flag to mark a client for deletion.

### 2. **Enums**
   - **`enMainMenuOptions`**: Represents the main menu options (e.g., List Clients, Add New Client, Delete Client, etc.).
   - **`enTransactionsMenuOption`**: Represents the transactions menu options (e.g., Deposit, Withdraw, Total Balances, etc.).

### 3. **Core Functions**
   - **`SplitString`**: Splits a string based on a delimiter.
   - **`ConvertLineToRecord`**: Converts a line from the file into a `stClient` struct.
   - **`ConvertRecordToLine`**: Converts a `stClient` struct into a string for file storage.
   - **`LoadClientsDataFromFile`**: Loads client data from the file into a list of `stClient`.
   - **`SaveClientsListToFile`**: Saves the list of clients back to the file.
   - **`PrintClientRecordLine`**: Displays a client's details in a formatted manner.
   - **`PrintClientCard`**: Displays detailed information about a single client.

### 4. **Main Functionalities**
   - **`ShowClientList`**: Displays a list of all clients.
   - **`AddNewClient`**: Adds a new client to the system.
   - **`DeleteClientByAccountNumber`**: Deletes a client by their account number.
   - **`UpdateClientByAccountNumber`**: Updates a client's information.
   - **`FindClientByAccountNumber`**: Finds and displays a client's details.
   - **`DepositeBalanceToClientByAccountNumber`**: Deposits money into a client's account.
   - **`ShowWithdrawScreen`**: Withdraws money from a client's account.
   - **`ShowTotalBalancesScreen`**: Displays the total balance of all clients.

### 5. **Menu Navigation**
   - **`ShowMainMenuScreen`**: Displays the main menu and handles user input.
   - **`ShowTransactionsMenuScreen`**: Displays the transactions menu and handles user input.
   - **`GoBackToMainMenu`**: Returns the user to the main menu.
   - **`GoBackToTransactionsMenu`**: Returns the user to the transactions menu.

---

## How It Works

1. **File Storage**:
   - The application reads and writes client data to a text file (`Clients.txt`).
   - Each client's data is stored as a single line in the file, with fields separated by the delimiter `#//#`.

2. **Menu-Driven Interface**:
   - The user is presented with a main menu where they can choose from various options.
   - Based on the user's choice, the application performs the corresponding operation (e.g., adding a client, deleting a client, etc.).

3. **Data Validation**:
   - The application ensures that duplicate account numbers are not added.
   - Withdrawal transactions are validated to ensure the amount does not exceed the client's balance.

4. **Persistence**:
   - All changes made to client data (e.g., adding, deleting, updating) are saved to the file, ensuring data persistence across application sessions.

---

## Usage

1. **Run the Application**:
   - Compile and run the C# program.
   - The main menu will be displayed.

2. **Main Menu Options**:
   - **1. Show Client List**: Displays all clients in the system.
   - **2. Add New Client**: Adds a new client to the system.
   - **3. Delete Client**: Deletes a client by their account number.
   - **4. Update Client Info**: Updates a client's information.
   - **5. Find Client**: Finds a client by their account number.
   - **6. Transactions**: Opens the transactions menu.
   - **7. Exit**: Exits the application.

3. **Transactions Menu Options**:
   - **1. Deposit**: Deposits money into a client's account.
   - **2. Withdraw**: Withdraws money from a client's account.
   - **3. Total Balances**: Displays the total balance of all clients.
   - **4. Main Menu**: Returns to the main menu.

---

## Example Data Format in `Clients.txt`

Each line in the file represents a client and is formatted as follows:

AccountNumber#//#PinCode#//#Name#//#Phone#//#AccountBalance


Example:

A150#//#6789#//#Abdelrahman Medhat#//#1234567890#//#1000.50


---

## Notes

- Ensure the `Clients.txt` file exists in the same directory as the executable. If the file does not exist, the application will notify the user.
- The application is designed for simplicity and does not include advanced error handling or encryption for sensitive data like PIN codes.

---

## How to Run

1. Clone or download the repository.
2. Open the project in an IDE (e.g., Visual Studio).
3. Compile and run the program.
4. Follow the on-screen instructions to interact with the system.

