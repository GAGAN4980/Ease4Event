# 📅 Ease4Event

**Ease4Event** is a simple Event Management web application built using the **ASP.NET Core MVC** framework with **Entity Framework Core** (model-first approach). It allows authenticated users to create, view, edit, and delete events efficiently.

---

## 🛠️ Technologies Used

- ASP.NET Core MVC  
- Entity Framework Core (Model-First)  
- SQL Server / LocalDB  
- C#  
- Bootstrap (for styling)  
- Visual Studio / VS Code  

---

## 🔧 Features

- ✅ User Authentication (Login/Register)  
- 🆕 Add New Events  
- 📋 View All Events  
- ✏️ Edit Events  
- 🗑️ Delete Events  
- 🗂️ Persistent storage using EF Core with SQL Server  

---

## 🗃️ Data Model

Each event has the following fields:
- **Title** (string)
- **Description** (text)
- **Date** (date)
- **Time** (time)
- **Location** (string)

---

## ⚙️ Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/Ease4Event.git
cd Ease4Event
```

### 2. Install Dependencies

Make sure EF Core tools are installed:

```bash
dotnet tool install --global dotnet-ef
```

Install necessary NuGet packages:

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### 3. Database Setup

Run the following commands to create the database:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the App

```bash
dotnet run
```

The app will be accessible at `https://localhost:5001` or `http://localhost:5000`

---

## 🔐 Authentication

Ease4Event includes a simple login and registration system. Only authenticated users can create, edit, or delete events.

---

## 📁 Folder Structure

```plaintext
/Models         → Contains the Event model  
/Views          → Razor views (UI templates)  
/Controllers    → MVC Controllers for Event and Account management  
/Data           → DbContext for EF Core  
wwwroot/        → Static files (CSS, JS, images)  
appsettings.json → Database connection string  
Program.cs      → App entry point  
```

---

## 📃 License

MIT License
