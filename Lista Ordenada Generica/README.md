# Generic Sorted List

## Description

This program implements a **generic sorted list** data structure in C# that automatically maintains its elements in sorted order. The implementation includes:

- **`ListaOrdenada<T>`**: A generic class that stores elements of any comparable type and keeps them sorted automatically
- **`Contacto`**: A sample class demonstrating how to use the sorted list with custom objects
- **Automated tests**: Comprehensive test suite validating all functionality with integers, strings, and custom objects

### Key Features

- **Automatic sorting**: Elements are always maintained in ascending order
- **No duplicates**: Prevents adding duplicate elements
- **Generic implementation**: Works with any type that implements `IComparable<T>`
- **Filtering**: Supports filtering elements with custom predicates
- **Indexer access**: Retrieve elements by index using `[]` notation

## Technologies

- **Language**: C# (C-Sharp)
- **.NET**: Requires .NET SDK or .NET Framework runtime
- **Generics**: Uses C# generic types and constraints
- **Interfaces**: `IComparable<T>`, `IEnumerable<T>`

## How to Execute

### Option 1: Using .NET CLI (Recommended)

```bash
dotnet run --file ejercicio.cs
```

Or compile and execute:

```bash
dotnet build ejercicio.cs
dotnet run
```

### Option 2: Using C# Compiler

```bash
csc ejercicio.cs
ejercicio.exe
```

### Option 3: Using Visual Studio

1. Open the file in Visual Studio
2. Press `F5` or click "Start" to run with debugging
3. Or press `Ctrl+F5` to run without debugging

### Expected Output

If all tests pass, you'll see output similar to:

```
[OK] Primer elemento
[OK] Segundo elemento
[OK] Tercer elemento
[OK] Cantidad de elementos
...
[OK] Tercer contacto tras eliminar Otro
```

If any test fails, you'll see an error message indicating which assertion failed.

## Author

**Mazza Leon, Fabrizio Lautaro**  
Student ID: 61848  
TUP-25-p3
