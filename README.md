# API Project

This is a .NET 7.0 Web API project for managing stock data, including company information, market capitalization, and associated comments.

### Key Features

- **Stock Management**: Manage stock details such as symbol, company name, purchase price, last dividend, industry, and market capitalization.
- **One-to-Many Relationship**: Each stock can have multiple associated comments.
- **Entity Framework Core**: Used for database interactions.
- **Swagger Integration**: API documentation is available via Swagger UI.

## Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any compatible database)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/sopho1/Stock_API.git
   cd DotNet
2. dotnet restore
3. dotnet ef database update
4. dotnet run
5. Access the API:
    - Swagger UI: http://localhost:port/swagger   

# License
This project is licensed under the MIT License.    