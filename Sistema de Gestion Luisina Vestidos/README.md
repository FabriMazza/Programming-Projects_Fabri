# Luisina Vestidos — Sistema de Gestión de Ventas

> 📚 Trabajo Final — Tecnicatura en Programación · UTN

![Electron](https://img.shields.io/badge/Electron-28.x-47848F?style=flat&logo=electron&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-ES2020-F7DF1E?style=flat&logo=javascript&logoColor=black)
![MySQL](https://img.shields.io/badge/MySQL-8.x-4479A1?style=flat&logo=mysql&logoColor=white)
![Node.js](https://img.shields.io/badge/Node.js-18+-339933?style=flat&logo=nodedotjs&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat&logo=windows&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-22c55e?style=flat)

Aplicación de escritorio completa para la gestión integral de ventas de una tienda de vestidos. Desarrollada con **Electron + JavaScript + MySQL**, permite administrar clientes, inventario, ventas, reportes y usuarios desde una interfaz moderna, sin necesidad de navegador ni servidor externo.

---

## 📋 Tabla de Contenidos

- [Tecnologías](#-tecnologías)
- [Arquitectura](#-arquitectura)
- [Funcionalidades](#-funcionalidades)
- [Base de Datos](#-base-de-datos)
- [Requisitos Previos](#-requisitos-previos)
- [Instalación](#-instalación)
- [Uso](#-uso)
- [Generar Ejecutable](#-generar-ejecutable-portable)
- [Estructura del Proyecto](#-estructura-del-proyecto)
- [Seguridad](#-seguridad)

---

## 🛠 Tecnologías

### Core
| Tecnología | Versión | Rol |
|---|---|---|
| **Electron** | 28.x | Framework de aplicación de escritorio. Combina Node.js con Chromium para ejecutar la app como un programa nativo de Windows. |
| **Node.js** | 18+ | Entorno de ejecución de JavaScript del lado del proceso principal. Maneja IPC, sistema de archivos y base de datos. |
| **JavaScript** | ES2020 | Lenguaje principal, tanto para el proceso principal (main process) como para el renderer. |
| **HTML5 / CSS3** | — | Interfaz de usuario. Las vistas se renderizan en el motor Chromium embebido por Electron. |

### Base de Datos
| Paquete | Versión | Descripción |
|---|---|---|
| **mysql2** | 3.x | Driver MySQL para Node.js con soporte de Promises. Gestiona el pool de conexiones y todas las queries. |
| **MySQL Server** | 5.7+ / 8.x | Motor de base de datos relacional. La base de datos se crea automáticamente al iniciar la app por primera vez. |

### Generación de Documentos
| Paquete | Versión | Descripción |
|---|---|---|
| **pdfkit** | 0.13 | Generación de comprobantes de venta y reportes en formato PDF directamente desde Node.js, sin dependencias externas. |
| **exceljs** | 4.x | Exportación de reportes y datos a archivos Excel (.xlsx) con formato y estilos. |
| **xlsx** | 0.18 | Lectura y escritura de archivos Excel, usado como complemento para operaciones de hoja de cálculo. |

### Comunicación
| Paquete | Versión | Descripción |
|---|---|---|
| **nodemailer** | 6.x | Envío de comprobantes de venta por correo electrónico vía SMTP (Gmail). |

### Visualización
| Paquete | Versión | Descripción |
|---|---|---|
| **Chart.js** | 4.x | Gráficos interactivos en el módulo de reportes (tortas, barras, líneas). |

### Build & Distribución
| Paquete | Descripción |
|---|---|
| **electron-builder** | Empaqueta la app en un ejecutable portable `.exe` para Windows listo para distribuir. |

---

## 🏗 Arquitectura

El sistema implementa el patrón **MVC (Modelo–Vista–Controlador)** adaptado al modelo de procesos de Electron:

```
┌─────────────────────────────────────────────────────────────┐
│                  PROCESO PRINCIPAL (main.js)                 │
│  • Crea ventanas (BrowserWindow)                            │
│  • Maneja IPC con ipcMain                                   │
│  • Gestiona diálogos nativos (guardar archivos, impresión)  │
│  • Inicializa la conexión a MySQL                           │
└─────────────────────┬───────────────────────────────────────┘
                      │  IPC (ipcRenderer / ipcMain)
┌─────────────────────▼───────────────────────────────────────┐
│                   PROCESO RENDERER (src/)                    │
│                                                             │
│  ┌─────────────┐   ┌──────────────┐   ┌─────────────────┐  │
│  │   VISTAS    │◄──│ CONTROLADORES│──►│   UTILIDADES    │  │
│  │  (views/)   │   │(controllers/)│   │    (utils/)     │  │
│  │             │   │              │   │                 │  │
│  │ • HTML/CSS  │   │ • Lógica de  │   │ • PDFGenerator  │  │
│  │ • DOM       │   │   negocio    │   │ • EmailService  │  │
│  │ • Eventos   │   │ • Queries SQL│   │ • db-helper     │  │
│  └─────────────┘   └──────┬───────┘   └─────────────────┘  │
│                           │                                  │
│                    ┌──────▼───────┐                         │
│                    │  DATABASE    │                          │
│                    │ (database/)  │                          │
│                    │  • db.js     │                          │
│                    │  • mysql-    │                          │
│                    │    config.js │                          │
│                    └─────────────┘                          │
└─────────────────────────────────────────────────────────────┘
                           │
                    ┌──────▼───────┐
                    │ MySQL Server │
                    │(luisina_     │
                    │ vestidos)    │
                    └─────────────┘
```

### Comunicación entre procesos (IPC)
Electron separa el proceso principal (`main.js`) del renderer (`src/`). La comunicación entre ambos se realiza mediante **IPC channels**:
- El renderer envía peticiones con `ipcRenderer.invoke()`
- El main process responde con `ipcMain.handle()`
- Se usa para: diálogos de guardado de archivos, impresión de PDFs, obtención de rutas del sistema

---

## ✨ Funcionalidades

### 👤 Usuarios
- CRUD completo con roles (Administrador / Empleado)
- Sistema de permisos por rol
- Papelera con restauración de usuarios eliminados
- Historial de auditoría (quién hizo qué y cuándo)
- Recuperación de contraseña por correo electrónico

### 👗 Vestidos (Inventario)
- Alta, baja y modificación de productos
- Códigos únicos autogenerados
- Categorías predefinidas y control de stock
- Historial de movimientos de inventario
- Búsqueda y filtros por categoría

### 👥 Clientes
- Registro y edición de clientes
- Historial de compras por cliente
- Búsqueda avanzada
- Venta a clientes registrados o anónimos

### 💰 Ventas (Operaciones)
- Carrito de compras en tiempo real
- Múltiples formas de pago: Efectivo, Débito, Crédito, Transferencia
- Aplicación de descuentos
- Generación de comprobante PDF al finalizar la venta
- Envío del comprobante por email (opcional)
- Actualización automática del stock

### 📊 Reportes
- Gráficos interactivos con Chart.js (tortas y barras)
- Filtros por día, mes y año
- Resumen de ingresos totales
- Ventas agrupadas por forma de pago
- Top 10 vestidos más vendidos
- Top 10 mejores clientes
- Exportación de reportes a PDF y Excel

### 📜 Historial
- Registro completo de todas las ventas
- Detalle de productos por venta
- Reimpresión de comprobantes anteriores
- Filtros avanzados por fecha y cliente

---

## 🗄 Base de Datos

La base de datos **MySQL** está normalizada a la **Tercera Forma Normal (3FN)** y se crea automáticamente al iniciar la aplicación por primera vez.

### Diagrama de entidades principales

```
┌──────────────┐     ┌───────────────┐     ┌─────────────┐
│   usuarios   │     │    ventas     │     │   clientes  │
├──────────────┤     ├───────────────┤     ├─────────────┤
│ id_usuario   │──┐  │ id_venta (PK) │  ┌──│ id_cliente  │
│ nombre       │  └─►│ id_usuario(FK)│  │  │ nombre      │
│ email        │     │ id_cliente(FK)│◄─┘  │ email       │
│ password     │     │ total         │     │ telefono    │
│ rol          │     │ forma_pago    │     └─────────────┘
│ estado       │     │ fecha         │
└──────────────┘     └───────┬───────┘
                             │
                     ┌───────▼───────┐     ┌─────────────┐
                     │detalles_venta │     │   vestidos  │
                     ├───────────────┤     ├─────────────┤
                     │ id_detalle(PK)│  ┌──│ id_vestido  │
                     │ id_venta  (FK)│  │  │ codigo      │
                     │ id_vestido(FK)│◄─┘  │ nombre      │
                     │ cantidad      │     │ precio      │
                     │ precio_unit   │     │ stock       │
                     │ subtotal      │     │ id_categoria│
                     └───────────────┘     └─────────────┘
```

### Tablas auxiliares
| Tabla | Descripción |
|---|---|
| `categorias` | Categorías de vestidos |
| `formas_pago` | Formas de pago disponibles |
| `historial_usuarios` | Auditoría de cambios sobre usuarios |
| `historial_clientes` | Auditoría de cambios sobre clientes |
| `historial_vestidos` | Registro de movimientos de inventario |
| `papelera_usuarios` | Usuarios eliminados con opción de restaurar |

---

## ✅ Requisitos Previos

- **Node.js** v18 o superior → [nodejs.org](https://nodejs.org)
- **MySQL Server** v5.7 o superior → [dev.mysql.com/downloads/mysql](https://dev.mysql.com/downloads/mysql/)
- **Sistema Operativo:** Windows 10 / 11

---

## 🚀 Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/luisina-vestidos.git
cd "luisina-vestidos/sistema ventas"
```

### 2. Instalar dependencias

```bash
npm install
```

### 3. Configurar la conexión a MySQL

Editá el archivo `src/database/mysql-config.js` y completá tu contraseña:

```javascript
module.exports = {
  host:     'localhost',
  port:     3306,
  user:     'root',
  password: 'tu_contraseña_mysql',  // ← completar aquí
  database: 'luisina_vestidos',     // La BD se crea automáticamente
  timezone: '-03:00',               // Zona horaria Argentina
  charset:  'utf8mb4'
};
```

> **Nota:** No es necesario crear la base de datos manualmente. Al iniciar la app por primera vez, el sistema crea la base de datos, todas las tablas y los datos iniciales automáticamente.

### 4. Iniciar la aplicación

```bash
npm start
```

---

## 🖥 Uso

### Credenciales por defecto

| Campo | Valor |
|---|---|
| Usuario | `admin` |
| Contraseña | `admin123` |

> ⚠️ **Importante:** Cambiá la contraseña del administrador después del primer inicio de sesión desde el módulo Usuarios.

### Flujo básico

1. Iniciá sesión con las credenciales por defecto.
2. Cargá los vestidos desde el módulo **Vestidos**.
3. Registrá clientes en el módulo **Clientes** (opcional; se puede vender a clientes anónimos).
4. Realizá ventas desde el módulo **Operaciones**.
5. Consultá estadísticas en el módulo **Reportes**.

---

## 📦 Generar Ejecutable Portable

Para compilar la app en un `.exe` portable listo para compartir:

```bash
# Opción 1: Script incluido (Windows)
COMPILAR.bat

# Opción 2: Comando directo
npm run build
```

El ejecutable se genera en `dist/LuisinaVestidos-Portable.exe`.

> El ejecutable portable **no requiere instalación**, pero sí requiere que MySQL Server esté instalado y corriendo en la máquina destino.

### Mover a otra computadora

```bash
# 1. Exportar la base de datos en la PC origen
mysqldump -u root -p luisina_vestidos > backup.sql

# 2. En la PC destino, importar los datos
mysql -u root -p -e "CREATE DATABASE luisina_vestidos CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;"
mysql -u root -p luisina_vestidos < backup.sql
```

Luego copiá el proyecto, configurá `mysql-config.js` con las credenciales de la nueva máquina y ejecutá `npm start`.

---

## 📁 Estructura del Proyecto

```
sistema ventas/
│
├── main.js                        # Proceso principal de Electron (IPC, ventanas, diálogos)
├── package.json                   # Dependencias y configuración de build
├── COMPILAR.bat                   # Script para generar el ejecutable en Windows
│
└── src/
    ├── index.html                 # Pantalla de login
    ├── dashboard.html             # Dashboard principal
    │
    ├── css/
    │   ├── login.css              # Estilos de la pantalla de login
    │   ├── dashboard.css          # Estilos del layout principal
    │   └── modules.css            # Estilos de todos los módulos
    │
    ├── database/
    │   ├── db.js                  # Pool de conexiones y creación automática de tablas
    │   └── mysql-config.js        # ← Configurar credenciales MySQL aquí
    │
    ├── imagenes/                  # Recursos gráficos (logo, imagen de fondo)
    │
    └── js/
        ├── dashboard.js           # Coordinador: carga módulos y gestiona navegación
        │
        ├── auth/
        │   └── login.js           # Lógica de autenticación
        │
        ├── controllers/           # Lógica de negocio y acceso a datos
        │   ├── usuarios-controller.js
        │   ├── clientes-controller.js
        │   ├── vestidos-controller.js
        │   ├── ventas-controller.js
        │   └── reportes-controller.js
        │
        ├── views/                 # Renderizado de la UI y manejo de eventos del DOM
        │   ├── inicio-view.js
        │   ├── usuarios-view.js
        │   ├── clientes-view.js
        │   ├── vestidos-view.js
        │   ├── operaciones-view.js
        │   ├── reportes-view.js
        │   └── historial-view.js
        │
        └── utils/                 # Servicios reutilizables
            ├── db-helper.js       # Helper para queries frecuentes
            ├── pdf-generator.js   # Generación de PDFs con PDFKit
            └── email-service.js   # Envío de correos con Nodemailer
```

---

## 🔒 Seguridad

- Autenticación con usuario y contraseña antes de acceder al sistema
- Sistema de roles: las funciones disponibles dependen del rol (Administrador / Empleado)
- Contraseñas almacenadas con hash en la base de datos
- Auditoría completa: todas las altas, bajas y modificaciones quedan registradas con usuario y fecha
- Papelera para usuarios: los registros eliminados no se borran físicamente y pueden restaurarse
- Validación de datos en el frontend antes de ejecutar cualquier operación en la base de datos