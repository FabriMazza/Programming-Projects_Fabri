# Product Stock Management - REST API

## Description

This project is a product stock management system built as a REST API with a console client. The system allows you to:

- List all products with their prices and stock levels
- List products that need restocking (stock < 3 units)
- Add stock to existing products
- Remove stock from products

The application uses a SQLite database to persist data and is automatically initialized with 10 sample products on first run.

## Technologies

- **C#** - Main programming language
- **.NET SDK** (6.0 or higher) - Development platform
- **ASP.NET Core Minimal APIs** - Web API framework
- **Entity Framework Core** - ORM for database operations
- **SQLite** - Lightweight embedded database
- **System.Net.Http** - HTTP client for API communication
- **System.Text.Json** - JSON serialization/deserialization

## Requirements

- [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)

## How to Run

### 1. Start the Server

Open a terminal in the project folder and run:

```bash
dotnet-script servidor.cs
```

The server will start on `http://localhost:5000` and will:
- Create the SQLite database (`tienda.db`) if it doesn't exist
- Initialize 10 sample products automatically
- Be ready to receive HTTP requests

### 2. Start the Client

Open a **second terminal** in the same folder and run:

```bash
dotnet-script cliente.cs
```

An interactive menu will appear with the following options:

```
=== PRODUCT STOCK MENU ===

1. List all products
2. List products to restock (stock < 3)
3. Add stock to a product
4. Remove stock from a product
0. Exit
```

### Example Usage

1. Select option **1** to view all products
2. Select option **3** to add stock:
   - Enter the product ID
   - Enter the quantity to add
3. Select option **4** to remove stock:
   - Enter the product ID
   - Enter the quantity to remove
4. Select option **2** to see which products need restocking

## Project Structure

- `servidor.cs` - REST API server with endpoints for product management
- `cliente.cs` - Console client with interactive menu
- `tienda.db` - SQLite database (created automatically on first run)

## API Endpoints

- `GET /productos` - Get all products
- `GET /productos/reponer` - Get products with stock < 3
- `POST /productos/agregar/{id}/{cantidad}` - Add stock to a product
- `POST /productos/quitar/{id}/{cantidad}` - Remove stock from a product

## Notes

- The server must be running before starting the client
- Stock cannot be negative (validation is enforced)
- All data is persisted in the SQLite database
- Both files use C# top-level statements for simplicity

---

**Author:** Mazza Leon, Fabrizio Lautaro