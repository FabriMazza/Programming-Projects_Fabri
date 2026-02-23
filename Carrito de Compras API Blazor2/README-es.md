# Carrito de Compras - Blazor WebAssembly & ASP.NET Core API

Una aplicación full-stack de carrito de compras construida con Blazor WebAssembly para el frontend y ASP.NET Core Web API para el backend.

## 📋 Descripción

Este es un sistema completo de carrito de compras para e-commerce que permite a los usuarios navegar productos, agregar artículos al carrito, gestionar cantidades y completar compras. La aplicación está dividida en dos componentes principales:

- **Cliente (cliente)**: Interfaz web interactiva construida con Blazor WebAssembly
- **Servidor (servidor)**: API RESTful construida con ASP.NET Core que maneja la lógica de negocio y persistencia de datos

## 🚀 Tecnologías Utilizadas

### Backend (servidor)
- **.NET 9.0**
- **ASP.NET Core Web API**
- **Entity Framework Core 9.0.5**
- **Base de datos SQLite**
- **C#**

### Frontend (cliente)
- **Blazor WebAssembly**
- **Microsoft.AspNetCore.Components.WebAssembly 9.0.3**
- **.NET 9.0**
- **HTML/CSS**

## 📦 Requisitos Previos

Antes de ejecutar la aplicación, asegúrate de tener instalado:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) o superior

## ⚙️ Instalación y Ejecución

### 1. Clonar o descargar el repositorio

### 2. Ejecutar el Backend (Servidor API)

Abre una terminal en el directorio raíz del proyecto y ejecuta:

```bash
cd servidor
dotnet restore
dotnet run
```

La API estará disponible en: `http://localhost:5184`

### 3. Ejecutar el Frontend (Cliente Blazor)

Abre una **nueva terminal** en el directorio raíz del proyecto y ejecuta:

```bash
cd cliente
dotnet restore
dotnet run
```

La aplicación web estará disponible en: `http://localhost:5177`

### 4. Acceder a la Aplicación

Abre tu navegador web y navega a: `http://localhost:5177`

> **Importante:** El servidor (API) debe estar ejecutándose antes de iniciar el cliente.

## 🗂️ Estructura del Proyecto

```
├── servidor/                      # Backend API
│   ├── Models/                    # Modelos de datos
│   │   ├── Carrito.cs            # Modelo de carrito de compras
│   │   ├── Producto.cs           # Modelo de producto
│   │   ├── Compra.cs             # Modelo de compra
│   │   └── Tienda.cs             # Contexto de base de datos
│   ├── Migrations/               # Migraciones de EF Core
│   └── Program.cs                # Configuración de API y endpoints
│
├── cliente/                       # Frontend Blazor
│   ├── Pages/                     # Componentes/páginas Razor
│   │   ├── Home.razor            # Página principal con catálogo
│   │   ├── Carrito.razor         # Vista del carrito de compras
│   │   ├── CarritoIcono.razor    # Componente ícono del carrito
│   │   └── Confirmacion.razor    # Confirmación de compra
│   ├── Services/                  # Servicios del cliente
│   │   ├── ApiService.cs         # Comunicación con la API
│   │   ├── CarritoService.cs     # Gestión del carrito
│   │   └── StockLocalService.cs  # Gestión de stock local
│   ├── Models/                    # Modelos del lado del cliente
│   └── Layout/                    # Componentes de diseño
│
└── tp6.sln                        # Archivo de solución
```

## 🎯 Funcionalidades Principales

- ✅ Explorar catálogo de productos
- ✅ Agregar productos al carrito de compras
- ✅ Gestionar items del carrito (agregar, eliminar, actualizar cantidades)
- ✅ Ver total del carrito y detalles de items
- ✅ Completar compra
- ✅ Gestión de stock en tiempo real
- ✅ Diseño responsive

## 🔌 Endpoints de la API

- `GET /` - Verificación de estado de la API
- `GET /productos` - Obtener todos los productos (soporta parámetro de búsqueda)
- `POST /carritos` - Crear un nuevo carrito de compras
- `GET /carritos/{carritoId}` - Obtener detalles del carrito
- `PUT /carritos/{carritoId}/{productoId}` - Agregar/actualizar producto en el carrito
- `DELETE /carritos/{carritoId}` - Vaciar carrito
- `POST /compras` - Completar compra

## 📝 Notas

- La base de datos (SQLite) se crea automáticamente en la primera ejecución
- El servidor usa CORS configurado para permitir conexiones desde cualquier origen
- El ID del carrito se almacena localmente en el navegador usando localStorage

## 🛠️ Desarrollo

Para realizar cambios en el proyecto:

1. **Backend**: Modifica archivos en la carpeta `servidor` y reinicia el servidor
2. **Frontend**: Modifica archivos `.razor` en la carpeta `cliente` - hot reload está habilitado por defecto

## 👨‍💻 Autor

Mazza Leon, Fabrizio Lautaro