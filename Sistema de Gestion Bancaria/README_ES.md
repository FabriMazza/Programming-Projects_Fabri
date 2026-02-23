# Sistema de Gestión Bancaria

## Descripción

Este programa es un sistema de gestión bancaria desarrollado en C# que simula operaciones bancarias básicas. El sistema permite administrar múltiples bancos, clientes y cuentas con diferentes tipos de beneficios.

### Características principales:

- **Tipos de Cuentas**: El sistema soporta tres tipos de cuentas con diferentes tasas de acumulación de puntos:
  - **Cuenta Oro**: 5% de puntos para pagos mayores a $1000, 3% para pagos menores
  - **Cuenta Plata**: 2% de puntos en todos los pagos
  - **Cuenta Bronce**: 1% de puntos en todos los pagos

- **Operaciones Bancarias**:
  - Depósitos
  - Retiros
  - Transferencias (entre cuentas del mismo banco o de diferentes bancos)
  - Pagos (que acumulan puntos según el tipo de cuenta)

- **Gestión de Clientes**: Cada cliente puede tener múltiples cuentas y mantiene un historial completo de todas sus operaciones.

- **Sistema de Puntos**: Los pagos realizados acumulan puntos de recompensa basados en el tipo de cuenta.

- **Múltiples Bancos**: El sistema permite gestionar varios bancos simultáneamente con sus respectivos clientes y cuentas.

## Tecnologías Utilizadas

- **Lenguaje**: C# (C Sharp)
- **Framework**: .NET
- **Paradigma**: Programación Orientada a Objetos (POO)
- **Características de C#**:
  - Clases abstractas
  - Herencia y polimorfismo
  - Propiedades auto-implementadas
  - LINQ (Language Integrated Query)
  - Expresiones lambda
  - Pattern matching con `is`
  - Formato de números con CultureInfo

## Cómo Ejecutar el Programa

### Requisitos Previos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado en su sistema (versión 6.0 o superior recomendada)

### Opción 1: Usando el comando dotnet run

1. Abra una terminal o línea de comandos
2. Navegue hasta el directorio donde se encuentra el archivo `ejercicio.cs`
3. Ejecute el siguiente comando:

```bash
dotnet run ejercicio.cs
```

### Opción 2: Compilando y ejecutando

1. Compile el archivo usando el compilador de C#:

```bash
csc ejercicio.cs
```

2. Ejecute el archivo generado:

```bash
ejercicio.exe
```

### Opción 3: Usando Visual Studio / Visual Studio Code

1. Abra el archivo `ejercicio.cs` en su IDE
2. Presione F5 o use el botón "Run" para ejecutar el programa

## Resultado del Programa

Al ejecutar el programa, se mostrará un informe detallado con:
- Información de cada banco (nombre y cantidad de clientes)
- Información de cada cliente (nombre, saldo total y puntos totales)
- Detalle de cada cuenta (número, saldo y puntos)
- Historial de operaciones realizadas en cada cuenta

El programa finaliza cuando el usuario presiona cualquier tecla.

## Autor

**Mazza Leon, Fabrizio Lautaro** 