# WARP.md

This file provides guidance to WARP (warp.dev) when working with code in this repository.

## Project Overview

This is an **EcommerceAPI** built with **ASP.NET Core 10 (preview)** using **Entity Framework Core 9.0.9** and **SQL Server**. The project follows a standard ASP.NET Web API structure with a separate test project using **xunit v3**.

### Architecture

- **Main Project**: `EcommerceAPI/` - ASP.NET Core Web API
- **Test Project**: `EcommerceAPI.Tests/` - xunit v3 test suite
- **Database**: SQL Server with Entity Framework Core Code-First approach
- **API Documentation**: OpenAPI/Swagger integration enabled for development

### Domain Models

The project defines an e-commerce domain with the following core entities:

- **Product**: Core product entity with pricing, inventory, and category relationships
  - Portuguese property names (Nome, Descricao, Preco, EstoqueQuantidade)
  - Relationships to Category, CartItem, and OrderItem (some models incomplete)
- **User**: User management with authentication preparation (PasswordHash field)
  - Relationships to Order and Cart entities
- **Category**: Currently empty/stub implementation

**Note**: The models reference additional entities (`CartItem`, `OrderItem`, `Order`, `Cart`) that are not yet implemented, indicating incomplete domain modeling.

## Common Development Commands

### Building & Running
```bash
# Build the entire solution
dotnet build

# Build specific projects
dotnet build EcommerceAPI/EcommerceAPI.csproj
dotnet build EcommerceAPI.Tests/EcommerceAPI.Tests.csproj

# Run the API (development)
dotnet run --project EcommerceAPI

# Run with hot reload (development)
dotnet watch --project EcommerceAPI
```

### Testing
```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal

# Run tests in specific project
dotnet test EcommerceAPI.Tests/EcommerceAPI.Tests.csproj

# Run single test method
dotnet test --filter "Test1"
```

### Database & Migrations
```bash
# Add new migration
dotnet ef migrations add MigrationName --project EcommerceAPI

# Update database
dotnet ef database update --project EcommerceAPI

# Drop database
dotnet ef database drop --project EcommerceAPI

# Generate SQL script from migrations
dotnet ef migrations script --project EcommerceAPI
```

### Package Management
```bash
# Add package to main project
dotnet add EcommerceAPI/EcommerceAPI.csproj package PackageName

# Add package to test project
dotnet add EcommerceAPI.Tests/EcommerceAPI.Tests.csproj package PackageName

# Restore packages
dotnet restore
```

## Development Environment Setup

1. **Prerequisites**: .NET 10 SDK (preview) - currently using `10.0.100-rc.1.25451.107`
2. **Database**: Configure SQL Server connection string in `appsettings.json`
3. **IDE**: Visual Studio 2022 (v17) or compatible editor
4. **Testing**: xunit v3 with Visual Studio Test Runner integration

## API Endpoints

Currently only has a sample endpoint:
- `GET /weatherforecast` - Sample weather data endpoint

The project includes an `.http` file (`EcommerceAPI.http`) for API testing with the base URL `http://localhost:5252`.

## Project-Specific Conventions

- **Language**: Mixed Portuguese/English naming (models use Portuguese property names)
- **Entity Framework**: Code-First approach with SQL Server
- **Testing Framework**: xunit v3 (latest preview)
- **API Documentation**: OpenAPI/Swagger enabled in development environment
- **Nullable Reference Types**: Enabled across the solution

## Important Notes for Development

- The project uses .NET 10 preview, ensure compatibility when adding packages
- Domain model is incomplete - missing referenced entities need implementation
- Portuguese naming convention used in domain models should be maintained
- Entity Framework migrations will be needed once DbContext is properly configured
- Test project currently has only placeholder tests