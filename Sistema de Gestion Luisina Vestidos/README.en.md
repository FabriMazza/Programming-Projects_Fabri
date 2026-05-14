# Luisina Vestidos — Sales Management System

> 📚 Final Project — Programming Technician Degree · UTN

![Electron](https://img.shields.io/badge/Electron-28.x-47848F?style=flat&logo=electron&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-ES2020-F7DF1E?style=flat&logo=javascript&logoColor=black)
![MySQL](https://img.shields.io/badge/MySQL-8.x-4479A1?style=flat&logo=mysql&logoColor=white)
![Node.js](https://img.shields.io/badge/Node.js-18+-339933?style=flat&logo=nodedotjs&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat&logo=windows&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-22c55e?style=flat)

A complete desktop application for comprehensive sales management of a dress shop. Built with **Electron + JavaScript + MySQL**, it allows managing customers, inventory, sales, reports, and users through a modern interface — no browser or external server required.

---

## 📋 Table of Contents

- [Technologies](#-technologies)
- [Architecture](#-architecture)
- [Features](#-features)
- [Database](#-database)
- [Prerequisites](#-prerequisites)
- [Installation](#-installation)
- [Usage](#-usage)
- [Generate Executable](#-generate-portable-executable)
- [Project Structure](#-project-structure)
- [Security](#-security)

---

## 🛠 Technologies

### Core
| Technology | Version | Role |
|---|---|---|
| **Electron** | 28.x | Desktop application framework. Combines Node.js with Chromium to run the app as a native Windows program. |
| **Node.js** | 18+ | JavaScript runtime for the main process. Handles IPC, file system, and database operations. |
| **JavaScript** | ES2020 | Primary language, used for both the main process and the renderer. |
| **HTML5 / CSS3** | — | User interface. Views are rendered in the Chromium engine embedded by Electron. |

### Database
| Package | Version | Description |
|---|---|---|
| **mysql2** | 3.x | MySQL driver for Node.js with Promise support. Manages the connection pool and all queries. |
| **MySQL Server** | 5.7+ / 8.x | Relational database engine. The database is created automatically on first launch. |

### Document Generation
| Package | Version | Description |
|---|---|---|
| **pdfkit** | 0.13 | Generates sales receipts and reports in PDF format directly from Node.js, with no external dependencies. |
| **exceljs** | 4.x | Exports reports and data to formatted Excel files (.xlsx). |
| **xlsx** | 0.18 | Read/write Excel files, used as a complement for spreadsheet operations. |

### Communication
| Package | Version | Description |
|---|---|---|
| **nodemailer** | 6.x | Sends sales receipts via email using SMTP (Gmail). |

### Visualization
| Package | Version | Description |
|---|---|---|
| **Chart.js** | 4.x | Interactive charts in the reports module (pie, bar, line). |

### Build & Distribution
| Package | Description |
|---|---|
| **electron-builder** | Packages the app into a portable `.exe` executable for Windows, ready to distribute. |

---

## 🏗 Architecture

The system implements the **MVC (Model–View–Controller)** pattern adapted to Electron's process model:

```
┌─────────────────────────────────────────────────────────────┐
│                   MAIN PROCESS (main.js)                     │
│  • Creates windows (BrowserWindow)                          │
│  • Handles IPC with ipcMain                                 │
│  • Manages native dialogs (save files, printing)            │
│  • Initializes the MySQL connection                         │
└─────────────────────┬───────────────────────────────────────┘
                      │  IPC (ipcRenderer / ipcMain)
┌─────────────────────▼───────────────────────────────────────┐
│                  RENDERER PROCESS (src/)                     │
│                                                             │
│  ┌─────────────┐   ┌──────────────┐   ┌─────────────────┐  │
│  │    VIEWS    │◄──│ CONTROLLERS  │──►│   UTILITIES     │  │
│  │  (views/)   │   │(controllers/)│   │    (utils/)     │  │
│  │             │   │              │   │                 │  │
│  │ • HTML/CSS  │   │ • Business   │   │ • PDFGenerator  │  │
│  │ • DOM       │   │   logic      │   │ • EmailService  │  │
│  │ • Events    │   │ • SQL Queries│   │ • db-helper     │  │
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

### Inter-process Communication (IPC)
Electron separates the main process (`main.js`) from the renderer (`src/`). Communication between them is done via **IPC channels**:
- The renderer sends requests with `ipcRenderer.invoke()`
- The main process responds with `ipcMain.handle()`
- Used for: save file dialogs, PDF printing, retrieving system paths

---

## ✨ Features

### 👤 Users
- Full CRUD with roles (Administrator / Employee)
- Role-based permissions system
- Recycle bin with soft-delete and user restoration
- Audit history (who did what and when)
- Password recovery via email

### 👗 Dresses (Inventory)
- Add, remove, and edit products
- Auto-generated unique codes
- Predefined categories and stock control
- Inventory movement history
- Search and filter by category

### 👥 Customers
- Customer registration and editing
- Purchase history per customer
- Advanced search
- Sales to registered or anonymous customers

### 💰 Sales (Operations)
- Real-time shopping cart
- Multiple payment methods: Cash, Debit, Credit, Bank Transfer
- Discount application
- PDF receipt generation at checkout
- Optional receipt delivery by email
- Automatic stock update

### 📊 Reports
- Interactive charts with Chart.js (pie and bar)
- Filters by day, month, and year
- Total revenue summary
- Sales grouped by payment method
- Top 10 best-selling dresses
- Top 10 best customers
- Export reports to PDF and Excel

### 📜 History
- Complete log of all sales
- Product details per sale
- Reprint of past receipts
- Advanced filters by date and customer

---

## 🗄 Database

The **MySQL** database is normalized to **Third Normal Form (3NF)** and is created automatically when the application is launched for the first time.

### Main entity diagram

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

### Auxiliary tables
| Table | Description |
|---|---|
| `categorias` | Dress categories |
| `formas_pago` | Available payment methods |
| `historial_usuarios` | Audit log for user changes |
| `historial_clientes` | Audit log for customer changes |
| `historial_vestidos` | Inventory movement log |
| `papelera_usuarios` | Soft-deleted users with restore option |

---

## ✅ Prerequisites

- **Node.js** v18 or higher → [nodejs.org](https://nodejs.org)
- **MySQL Server** v5.7 or higher → [dev.mysql.com/downloads/mysql](https://dev.mysql.com/downloads/mysql/)
- **Operating System:** Windows 10 / 11

---

## 🚀 Installation

### 1. Clone the repository

```bash
git clone https://github.com/tu-usuario/luisina-vestidos.git
cd "luisina-vestidos/sistema ventas"
```

### 2. Install dependencies

```bash
npm install
```

### 3. Configure the MySQL connection

Edit the file `src/database/mysql-config.js` and fill in your password:

```javascript
module.exports = {
  host:     'localhost',
  port:     3306,
  user:     'root',
  password: 'your_mysql_password',  // ← fill in here
  database: 'luisina_vestidos',     // The DB is created automatically
  timezone: '-03:00',               // Argentina timezone
  charset:  'utf8mb4'
};
```

> **Note:** There is no need to create the database manually. On first launch, the system automatically creates the database, all tables, and the initial seed data.

### 4. Start the application

```bash
npm start
```

---

## 🖥 Usage

### Default credentials

| Field | Value |
|---|---|
| Username | `admin` |
| Password | `admin123` |

> ⚠️ **Important:** Change the administrator password after the first login from the Users module.

### Basic workflow

1. Log in with the default credentials.
2. Add dresses from the **Dresses** module.
3. Register customers in the **Customers** module (optional; sales to anonymous customers are supported).
4. Process sales from the **Operations** module.
5. View statistics in the **Reports** module.

---

## 📦 Generate Portable Executable

To compile the app into a portable `.exe` ready to share:

```bash
# Option 1: Included script (Windows)
COMPILAR.bat

# Option 2: Direct command
npm run build
```

The executable is generated at `dist/LuisinaVestidos-Portable.exe`.

> The portable executable **does not require installation**, but MySQL Server must be installed and running on the target machine.

### Moving to another computer

```bash
# 1. Export the database on the source PC
mysqldump -u root -p luisina_vestidos > backup.sql

# 2. On the target PC, import the data
mysql -u root -p -e "CREATE DATABASE luisina_vestidos CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;"
mysql -u root -p luisina_vestidos < backup.sql
```

Then copy the project, configure `mysql-config.js` with the new machine's credentials, and run `npm start`.

---

## 📁 Project Structure

```
sistema ventas/
│
├── main.js                        # Electron main process (IPC, windows, dialogs)
├── package.json                   # Dependencies and build configuration
├── COMPILAR.bat                   # Script to generate the Windows executable
│
└── src/
    ├── index.html                 # Login screen
    ├── dashboard.html             # Main dashboard
    │
    ├── css/
    │   ├── login.css              # Login screen styles
    │   ├── dashboard.css          # Main layout styles
    │   └── modules.css            # Styles for all modules
    │
    ├── database/
    │   ├── db.js                  # Connection pool and automatic table creation
    │   └── mysql-config.js        # ← Configure MySQL credentials here
    │
    ├── imagenes/                  # Graphic assets (logo, background image)
    │
    └── js/
        ├── dashboard.js           # Coordinator: loads modules and manages navigation
        │
        ├── auth/
        │   └── login.js           # Authentication logic
        │
        ├── controllers/           # Business logic and data access
        │   ├── usuarios-controller.js
        │   ├── clientes-controller.js
        │   ├── vestidos-controller.js
        │   ├── ventas-controller.js
        │   └── reportes-controller.js
        │
        ├── views/                 # UI rendering and DOM event handling
        │   ├── inicio-view.js
        │   ├── usuarios-view.js
        │   ├── clientes-view.js
        │   ├── vestidos-view.js
        │   ├── operaciones-view.js
        │   ├── reportes-view.js
        │   └── historial-view.js
        │
        └── utils/                 # Reusable services
            ├── db-helper.js       # Helper for frequent queries
            ├── pdf-generator.js   # PDF generation with PDFKit
            └── email-service.js   # Email sending with Nodemailer
```

---

## 🔒 Security

- Authentication with username and password before accessing the system
- Role-based system: available features depend on the role (Administrator / Employee)
- Passwords stored as hashes in the database
- Full audit trail: all create, delete, and update operations are logged with user and timestamp
- Soft-delete for users: deleted records are not physically removed and can be restored
- Frontend data validation before executing any database operation