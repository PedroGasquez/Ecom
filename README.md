# E-commerce API

A modern, scalable e-commerce API built with .NET 10 and Entity Framework Core.

## 🚀 Features

- **RESTful API Design** - Clean, well-structured endpoints
- **Entity Framework Core** - Modern ORM with SQL Server support
- **OpenAPI/Swagger** - Interactive API documentation
- **Unit Testing** - Comprehensive test coverage with xUnit
- **Modern .NET 10** - Latest framework with improved performance
- **Development Ready** - Hot reload and development optimizations

## 🛠️ Tech Stack

- **.NET 10** - Latest .NET framework
- **ASP.NET Core Web API** - Web API framework
- **Entity Framework Core 9.0** - Object-relational mapping
- **SQL Server** - Database provider
- **xUnit** - Testing framework
- **OpenAPI** - API documentation

## 📋 Prerequisites

Before running this project, make sure you have:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) installed
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB, Express, or full version)
- [Visual Studio 2024](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## ⚡ Quick Start

### 1. Clone the repository
```bash
git clone https://github.com/yourusername/ecom.git
cd ecom
```

### 2. Restore dependencies
```bash
dotnet restore
```

### 3. Update database connection
Update the connection string in `appsettings.json` and `appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EcommerceDB;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

### 4. Run database migrations
```bash
dotnet ef database update --project EcommerceAPI
```

### 5. Run the application
```bash
dotnet run --project EcommerceAPI
```

The API will be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`
- Swagger UI: `https://localhost:5001/swagger`

## 🏗️ Project Structure



## 🧪 Running Tests

Run all tests:
```bash
dotnet test
```

Run tests with coverage:
```bash
dotnet test --collect:"XPlat Code Coverage"
```

## 📊 API Documentation

When running in development mode, access the interactive API documentation at:
- **Swagger UI**: `https://localhost:5001/swagger`
- **OpenAPI JSON**: `https://localhost:5001/swagger/v1/swagger.json`

## 🔧 Development

### Adding New Migrations
```bash
dotnet ef migrations add MigrationName --project EcommerceAPI
dotnet ef database update --project EcommerceAPI
```

### Building the Project
```bash
dotnet build
```

### Publishing
```bash
dotnet publish -c Release -o ./publish
```

## 🌍 Environment Variables

Create a `.env` file or set environment variables:

```
ASPNETCORE_ENVIRONMENT=Development
ConnectionStrings__DefaultConnection=YourConnectionString
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 🚦 Status

This project is currently in development. Features being implemented:

- [ ] User authentication and authorization
- [ ] Product management endpoints
- [ ] Order management system
- [ ] Shopping cart functionality
- [ ] Payment integration
- [ ] Admin panel APIs
