# Gestión de Stock de Productos - API REST

## Descripción

Este proyecto es un sistema de gestión de stock de productos implementado como una API REST con un cliente de consola. El sistema permite:

- Listar todos los productos con sus precios y niveles de stock
- Listar productos que necesitan reposición (stock < 3 unidades)
- Agregar stock a productos existentes
- Quitar stock de productos

La aplicación utiliza una base de datos SQLite para persistir los datos y se inicializa automáticamente con 10 productos de muestra en la primera ejecución.

## Tecnologías

- **C#** - Lenguaje de programación principal
- **.NET SDK** (6.0 o superior) - Plataforma de desarrollo
- **ASP.NET Core Minimal APIs** - Framework de API web
- **Entity Framework Core** - ORM para operaciones de base de datos
- **SQLite** - Base de datos embebida ligera
- **System.Net.Http** - Cliente HTTP para comunicación con la API
- **System.Text.Json** - Serialización/deserialización JSON

## Requisitos

- [.NET SDK 6.0 o superior](https://dotnet.microsoft.com/download)

## Cómo Ejecutar

### 1. Iniciar el Servidor

Abre una terminal en la carpeta del proyecto y ejecuta:

```bash
dotnet-script servidor.cs
```

El servidor se iniciará en `http://localhost:5000` y automáticamente:
- Creará la base de datos SQLite (`tienda.db`) si no existe
- Inicializará 10 productos de muestra
- Quedará listo para recibir peticiones HTTP

### 2. Iniciar el Cliente

Abre una **segunda terminal** en la misma carpeta y ejecuta:

```bash
dotnet-script cliente.cs
```

Aparecerá un menú interactivo con las siguientes opciones:

```
=== MENÚ STOCK DE PRODUCTOS ===

1. Listar todos los productos
2. Listar productos a reponer (stock < 3)
3. Agregar stock a un producto
4. Quitar stock a un producto
0. Salir
```

### Ejemplo de Uso

1. Selecciona la opción **1** para ver todos los productos
2. Selecciona la opción **3** para agregar stock:
   - Ingresa el ID del producto
   - Ingresa la cantidad a agregar
3. Selecciona la opción **4** para quitar stock:
   - Ingresa el ID del producto
   - Ingresa la cantidad a quitar
4. Selecciona la opción **2** para ver qué productos necesitan reposición

## Estructura del Proyecto

- `servidor.cs` - Servidor API REST con endpoints para gestión de productos
- `cliente.cs` - Cliente de consola con menú interactivo
- `tienda.db` - Base de datos SQLite (se crea automáticamente en la primera ejecución)

## Endpoints de la API

- `GET /productos` - Obtener todos los productos
- `GET /productos/reponer` - Obtener productos con stock < 3
- `POST /productos/agregar/{id}/{cantidad}` - Agregar stock a un producto
- `POST /productos/quitar/{id}/{cantidad}` - Quitar stock de un producto

## Notas

- El servidor debe estar ejecutándose antes de iniciar el cliente
- El stock no puede ser negativo (se valida automáticamente)
- Todos los datos se persisten en la base de datos SQLite
- Ambos archivos utilizan top-level statements de C# para mayor simplicidad

---

**Autor:** Mazza Leon, Fabrizio Lautaro