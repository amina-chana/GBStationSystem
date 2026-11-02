# GBStation – Stationery Supplies Management System

A desktop-based stationery management system developed using **VB.NET Windows Forms** and **SQL Server LocalDB**. GBStation is designed to simplify daily stationery shop operations by managing products, customers, sales, inventory, and sales reporting.

## Features

- **User Authentication:** Login and logout functionality.
- **Dashboard:** Overview of products, customers, and daily sales.
- **Product Management:** Add, update, delete, search, and view products.
- **Customer Management:** Register, update, search, and manage customer records.
- **Sales Management:** Record sales, calculate totals, and process transactions.
- **Inventory Management:** Automatically update product stock after sales.
- **Receipts:** Generate and save sales receipts.
- **Reports:** View sales and revenue summaries.
- **Settings:** Customize selected application display settings.
- **Validation:** Input validation and error handling.

## Technologies Used

- Visual Basic .NET (VB.NET)
- Windows Forms
- Microsoft SQL Server LocalDB
- ADO.NET
- Visual Studio 2022

## Project Structure

```text
GBStationSystem/
├── gbstationsystem/
│   ├── Forms and application source files
│   └── Project configuration
├── screenshots/
├── gbstationsystem.sln
└── README.md
```

## Database

The application uses a SQL Server LocalDB database named `GBStationDB`.

The database stores:
- Products
- Customers
- Sales
- Sale items

To run the application, configure the database and connection string in `DatabaseConnection.vb`.

## Getting Started

1. Install Visual Studio 2022.
2. Install SQL Server Express LocalDB.
3. Clone or download this repository.
4. Open `gbstationsystem.sln` in Visual Studio.
5. Create or restore the `GBStationDB` database.
6. Confirm the database connection string.
7. Build and run the application.

## Screenshots

Application screenshots are available in the `screenshots` folder.

## Developer

**Amina Chana**  
Computer Science Student

## Project Purpose

GBStation was developed as a practical solution to improve stationery shop operations by reducing manual record keeping, simplifying sales processing, and improving inventory tracking.

---

*This project is intended for learning and demonstration purposes.*
