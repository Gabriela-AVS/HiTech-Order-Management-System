# HiTech Order Management System

Academic multi-tier desktop application developed for an order-management business scenario.

The project models the workflow of a technical-book distributor and separates responsibilities across different business roles. Users authenticate to the application and receive access according to their job function.

## Business roles

- **MIS Manager** — manages employees and user accounts.
- **Sales Manager** — manages customer information.
- **Inventory Controller** — manages books, inventory, categories, authors, and publishers.
- **Order Clerk** — creates, searches, updates, lists, and cancels customer orders.

The application checks the logged-in user's role before opening each department area.

## Architecture

The project uses a multi-tier structure:

- **GUI** — Windows Forms user interface
- **BLL** — business/domain objects and session logic
- **DAL** — database access and repositories
- **SQL Server** — relational database

The project also demonstrates different .NET data-access approaches used during the course, including ADO.NET, LINQ to SQL, and Entity Framework 6.

## Technologies

- C#
- .NET Framework 4.7.2
- Windows Forms
- SQL Server / SQL Server Express
- ADO.NET
- LINQ to SQL
- Entity Framework 6
- Visual Studio
- Object-oriented programming
- Multi-tier architecture

## Business logic and access control

A major focus of the project was translating business requirements into application logic. Different departments require different information and permissions, so the application maintains the logged-in employee's role and checks it before granting access to department-specific functionality.

My contribution focused especially on understanding the relationships between departments, translating business needs into program logic, and implementing access rules for the different teams and users.

## Database

A portfolio-safe database setup script is included in [`database/HiTechDb.sql`](database/HiTechDb.sql).

The public version of the project does **not** contain my local SQL Server password or computer/server name. Demo login records in the SQL script are sample data only.

> **Security note:** This was an academic project. The original course implementation uses simple demo credentials to demonstrate role-based application access. A production version should store passwords using secure salted password hashing rather than plain-text passwords.

## Running the project

1. Install Visual Studio with .NET Framework 4.7.2 development tools.
2. Install SQL Server / SQL Server Express.
3. Run `database/HiTechDb.sql` to create the sample database.
4. Open `HiTechOrderManagementSystem.sln` in Visual Studio.
5. Restore the NuGet packages when prompted.
6. In `HiTechOrderManagementSystem/App.config`, replace `YOUR_SERVER\\SQLEXPRESS` with your SQL Server instance name.
7. Build and run the application.

## What I learned

This project helped me connect programming with real business requirements rather than treating each feature in isolation. I particularly enjoyed designing logic around departments, responsibilities, user permissions, and the way data moves between different parts of the business.

## Future improvements

- Hash and salt user passwords.
- Move environment-specific database configuration outside the tracked configuration file.
- Add automated unit and integration tests.
- Improve exception handling and logging.
- Refactor older data-access approaches into a more consistent repository/service architecture.

---

**Academic portfolio project — Collège LaSalle**
