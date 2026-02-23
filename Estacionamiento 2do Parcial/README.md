# Estacionamiento Rivadavia - Sistema de Gestión

## 📋 Descripción

Sistema de gestión de estacionamiento desarrollado en C# que permite administrar el ingreso y salida de vehículos, calcular tarifas y llevar un registro de la recaudación. El sistema maneja tres tipos de vehículos: motos, autos y camionetas, cada uno con su propia tarifa por hora.

## ✨ Funcionalidades

- **Ingresar Vehículo**: Registra vehículos con su chapa, tipo y hora de ingreso
- **Buscar Vehículo**: Busca vehículos por número de chapa
- **Ver Cantidad de Vehículos**: Muestra la cantidad de vehículos por tipo actualmente en el estacionamiento
- **Ver Vehículos Ordenados**: Lista todos los vehículos ordenados por hora de ingreso
- **Dar Salida a Vehículo**: Procesa la salida del vehículo y calcula el monto a pagar
- **Ver Recaudación**: Muestra la recaudación total y por tipo de vehículo
- **Ver Todas las Chapas**: Lista todas las chapas y tipos de vehículos ingresados

## 💰 Tarifas

- **Moto**: $200 por hora
- **Auto**: $500 por hora
- **Camioneta**: $700 por hora

*Nota: El cálculo se realiza por hora completa o fracción.*

## 🚀 Cómo Ejecutar

### Requisitos Previos

- .NET 8.0 SDK o superior instalado
- Sistema Operativo: Windows, Linux o macOS

### Ejecución desde la Terminal

1. Navegar al directorio del proyecto:
```bash
cd "Estacionamiento 2do Parcial"
```

2. Ejecutar el programa:
```bash
dotnet run
```

### Ejecución desde Visual Studio

1. Abrir el archivo `Estacionamiento 2do Parcial.sln`
2. Presionar `F5` o hacer clic en el botón "Iniciar"

### Compilación

Para compilar el proyecto sin ejecutarlo:
```bash
dotnet build
```

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C# 12
- **Framework**: .NET 8.0
- **Tipo de Aplicación**: Aplicación de consola
- **Estructuras de Datos**: 
  - `List<string>` para almacenar chapas y tipos de vehículos
  - `List<DateTime>` para almacenar horas de ingreso
- **Características del Lenguaje**:
  - Tuplas para ordenamiento de vehículos
  - LINQ para ordenamiento de datos
  - Expresiones lambda

## 📝 Ejemplo de Uso

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
## 👨‍💻 Autor

Mazza Leon, Fabrizio Lautaro