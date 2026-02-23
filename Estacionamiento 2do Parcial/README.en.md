# Estacionamiento Rivadavia - Parking Management System

## 📋 Description

Parking management system developed in C# that allows managing vehicle entry and exit, calculating fees, and keeping track of revenue. The system handles three types of vehicles: motorcycles, cars, and trucks, each with its own hourly rate.

## ✨ Features

- **Vehicle Entry**: Register vehicles with their license plate, type, and entry time
- **Search Vehicle**: Search for vehicles by license plate number
- **View Vehicle Count**: Display the number of vehicles by type currently in the parking lot
- **View Sorted Vehicles**: List all vehicles sorted by entry time
- **Vehicle Exit**: Process vehicle departure and calculate payment amount
- **View Revenue**: Display total revenue and revenue by vehicle type
- **View All Plates**: List all license plates and vehicle types entered

## 💰 Pricing

- **Motorcycle**: $200 per hour
- **Car**: $500 per hour
- **Truck**: $700 per hour

*Note: Calculation is done per hour or fraction thereof.*

## 🚀 How to Run

### Prerequisites

- .NET 8.0 SDK or higher installed
- Operating System: Windows, Linux, or macOS

### Running from Terminal

1. Navigate to the project directory:
```bash
cd "Estacionamiento 2do Parcial"
```

2. Run the program:
```bash
dotnet run
```

### Running from Visual Studio

1. Open the `Estacionamiento 2do Parcial.sln` file
2. Press `F5` or click the "Start" button

### Building

To build the project without running it:
```bash
dotnet build
```

## 🛠️ Technologies Used

- **Language**: C# 12
- **Framework**: .NET 8.0
- **Application Type**: Console Application
- **Data Structures**: 
  - `List<string>` for storing license plates and vehicle types
  - `List<DateTime>` for storing entry times
- **Language Features**:
  - Tuples for vehicle sorting
  - LINQ for data ordering
  - Lambda expressions

## 📝 Usage Example

```
=========================
ESTACIONAMIENTO RIVADAVIA
=========================

MENÚ DE OPCIONES:

1. Ingresar Vehículo
2. Buscar Vehículo por Chapa
3. Ver Cantidad de Vehículos por Tipo
4. Ver Vehículos Ordenados por Hora de Ingreso
5. Dar Salida a Vehículo
6. Ver Recaudación
7. Ver Todas las Chapas y Tipos Ingresados
8. Salir

Seleccione una opción: 
```

## 👨‍💻 Author

Mazza Leon, Fabrizio Lautaro