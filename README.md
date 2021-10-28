# BMWQuiz
## Overview
Back-end part of BWM Quiz, containing all the business rules, database migrations and a web api.

## Instalation and usage
### Requirements
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Entity Framework Core CLI](https://docs.microsoft.com/pt-br/ef/core/cli/dotnet) (optional)

### Generate the database
- The default database location is at `C:\SQLiteStudio\BMWQuiz.db`. If you want to change the target location, go to `appsettings.json` file on `Presentation.API` project, and change the `SQLite` connection string.
- To generate the database, you can either use the EF CLI with the command `dotnet ef database update`, or in the PM Console in Visual Studio with the command `database-update`. In both cases, don't forget to choose the `Infra.Data` as default project.
### Run the web API
- Open a CLI in the `Presentation.API` project, and run `dotnet run`. If you want to use hot reload, use `dotnet watch run`.
