# CodeFirst---EFCore (NBA Database API)

An ASP.NET Core Web API that models an NBA database using **Entity Framework Core with a Code First approach**. The project demonstrates how to define entities, relationships and migrations from C# code.

## Tech stack

- **ASP.NET Core Web API** (.NET 10)
- **Entity Framework Core** — Code First
- **SQL Server** (LocalDB / SQL Server with `Trusted_Connection`)
- OpenAPI (Swagger UI) in development

## Domain model

- **Team** — an NBA team
  - has many `Players`
- **Player** — an NBA player
  - belongs to one `Team`

An initial migration (`InitCreate`) has already been created and is included in `Migrations/`.

## Getting started

```bash
git clone https://github.com/Linaslala/CodeFirst---EFCore.git
cd CodeFirst---EFCore
dotnet restore
dotnet ef database update
dotnet run
```

Update the connection string in `appsettings.json` to match your SQL Server instance. With OpenAPI enabled you can explore the endpoints at `/openapi/v1.json` in development.

## Possible future improvements

- Add controllers/endpoints for teams and players
- Add seeding of NBA data
- Add DTOs and API versioning
- Add tests for the API