# 🎓 StudentRegistry

A simple ASP.NET Core web application for managing student records.

## Features

- Add, edit, delete, and view students
- Search students by name or email
- Form validation
- Bootstrap UI

## Tech Stack

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap

## Project Structure

- `Models/Student.cs` - Student data model
- `Controllers/` - MVC controllers
- `Views/` - Razor views
- `Data/ApplicationDbContext.cs` - Database context
- `wwwroot/` - Static files (CSS, JS)

## Prerequisites

- .NET 8 SDK
- SQL Server

## Setup

1. Clone the repository
```bash
git clone https://github.com/ismaillaa/StudentRegistry.git
cd StudentRegistry
```

2. Restore packages
```bash
dotnet restore
```

3. Update database connection string in `appsettings.json`

4. Run migrations
```bash
dotnet ef database update
```

5. Run the application
```bash
dotnet run
```

## Student Model

- Name (required, max 50 characters)
- Age (required)
- Email (required, valid email format)
- Date of Birth (required)

## License

MIT License

