# Shopping Cart - Blazor WebAssembly & ASP.NET Core API

A full-stack shopping cart application built with Blazor WebAssembly for the frontend and ASP.NET Core Web API for the backend.

## 📋 Description

This is a complete e-commerce shopping cart system that allows users to browse products, add items to their cart, manage quantities, and complete purchases. The application is divided into two main components:

- **Client (cliente)**: Interactive web interface built with Blazor WebAssembly
- **Server (servidor)**: RESTful API built with ASP.NET Core that handles business logic and data persistence

## 🚀 Technologies Used

### Backend (servidor)
- **.NET 9.0**
- **ASP.NET Core Web API**
- **Entity Framework Core 9.0.5**
- **SQLite Database**
- **C#**

### Frontend (cliente)
- **Blazor WebAssembly**
- **Microsoft.AspNetCore.Components.WebAssembly 9.0.3**
- **.NET 9.0**
- **HTML/CSS**

## 📦 Prerequisites

Before running the application, make sure you have installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or higher

## ⚙️ Installation and Execution

### 1. Clone or download the repository

### 2. Run the Backend (API Server)

Open a terminal in the project root directory and execute:

```bash
cd servidor
dotnet restore
dotnet run
```

The API will be available at: `http://localhost:5184`

### 3. Run the Frontend (Blazor Client)

Open a **new terminal** in the project root directory and execute:

```bash
cd cliente
dotnet restore
dotnet run
```

The web application will be available at: `http://localhost:5177`

### 4. Access the Application

Open your web browser and navigate to: `http://localhost:5177`

> **Important:** The server (API) must be running before starting the client.

## 🗂️ Project Structure

```
├── servidor/                      # Backend API
│   ├── Models/                    # Data models
│   │   ├── Carrito.cs            # Shopping cart model
│   │   ├── Producto.cs           # Product model
│   │   ├── Compra.cs             # Purchase model
│   │   └── Tienda.cs             # Database context
│   ├── Migrations/               # EF Core migrations
│   └── Program.cs                # API configuration and endpoints
│
├── cliente/                       # Frontend Blazor
│   ├── Pages/                     # Razor components/pages
│   │   ├── Home.razor            # Main page with product catalog
│   │   ├── Carrito.razor         # Shopping cart view
│   │   ├── CarritoIcono.razor    # Cart icon component
│   │   └── Confirmacion.razor    # Purchase confirmation
│   ├── Services/                  # Client services
│   │   ├── ApiService.cs         # API communication
│   │   ├── CarritoService.cs     # Cart management
│   │   └── StockLocalService.cs  # Local stock management
│   ├── Models/                    # Client-side models
│   └── Layout/                    # Layout components
│
└── tp6.sln                        # Solution file
```

## 🎯 Main Features

- ✅ Browse product catalog
- ✅ Add products to shopping cart
- ✅ Manage cart items (add, remove, update quantities)
- ✅ View cart total and item details
- ✅ Complete purchase
- ✅ Real-time stock management
- ✅ Responsive design

## 🔌 API Endpoints

- `GET /` - API health check
- `GET /productos` - Get all products (supports search parameter)
- `POST /carritos` - Create a new shopping cart
- `GET /carritos/{carritoId}` - Get cart details
- `PUT /carritos/{carritoId}/{productoId}` - Add/update product in cart
- `DELETE /carritos/{carritoId}` - Empty cart
- `POST /compras` - Complete purchase

## 📝 Notes

- The database (SQLite) is automatically created on the first run
- The server uses CORS configured to allow connections from any origin
- Cart ID is stored locally in the browser using localStorage

## 🛠️ Development

To make changes to the project:

1. **Backend**: Modify files in the `servidor` folder and restart the server
2. **Frontend**: Modify `.razor` files in the `cliente` folder - hot reload is enabled by default

## 👨‍💻 Autor

Mazza Leon, Fabrizio Lautaro