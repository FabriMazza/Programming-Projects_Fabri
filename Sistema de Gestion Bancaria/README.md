# Banking Management System

## Description

This program is a banking management system developed in C# that simulates basic banking operations. The system allows managing multiple banks, clients, and accounts with different types of benefits.

### Main Features:

- **Account Types**: The system supports three types of accounts with different point accumulation rates:
  - **Gold Account**: 5% points for payments over $1000, 3% for smaller payments
  - **Silver Account**: 2% points on all payments
  - **Bronze Account**: 1% points on all payments

- **Banking Operations**:
  - Deposits
  - Withdrawals
  - Transfers (between accounts in the same bank or different banks)
  - Payments (which accumulate points based on account type)

- **Client Management**: Each client can have multiple accounts and maintains a complete history of all their operations.

- **Points System**: Payments made accumulate reward points based on the account type.

- **Multiple Banks**: The system allows managing several banks simultaneously with their respective clients and accounts.

## Technologies Used

- **Language**: C# (C Sharp)
- **Framework**: .NET
- **Paradigm**: Object-Oriented Programming (OOP)
- **C# Features**:
  - Abstract classes
  - Inheritance and polymorphism
  - Auto-implemented properties
  - LINQ (Language Integrated Query)
  - Lambda expressions
  - Pattern matching with `is`
  - Number formatting with CultureInfo

## How to Run the Program

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your system (version 6.0 or higher recommended)

### Option 1: Using dotnet run command

1. Open a terminal or command prompt
2. Navigate to the directory where the `ejercicio.cs` file is located
3. Run the following command:

```bash
dotnet run ejercicio.cs
```

### Option 2: Compiling and executing

1. Compile the file using the C# compiler:

```bash
csc ejercicio.cs
```

2. Run the generated file:

```bash
ejercicio.exe
```

### Option 3: Using Visual Studio / Visual Studio Code

1. Open the `ejercicio.cs` file in your IDE
2. Press F5 or use the "Run" button to execute the program

## Program Output

When running the program, a detailed report will be displayed with:
- Information about each bank (name and number of clients)
- Information about each client (name, total balance, and total points)
- Details of each account (number, balance, and points)
- History of operations performed on each account

The program ends when the user presses any key.

## Author

**Mazza Leon, Fabrizio Lautaro** 