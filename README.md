# MovieApp

Movie rating application built with ASP.NET Core (.NET 9), EF Core (SQLite), MudBlazor UI, and ASP.NET Identity.

---
### Features
- Register / login
- Add & list movies (WIP)
- Rate movies (WIP)

### Prerequisites:
- .NET 9 SDK installed (`dotnet --version`)
(No DB setup needed; a local SQLite file is created automatically.)

--- 

### Clean build + run:
```bash
cd MovieApp
dotnet clean && dotnet build && dotnet run
```
Open the shown URL (e.g. http://localhost:5243 or https://localhost:7002).

### Development

Run (development):
```bash
cd MovieApp
dotnet run
```

Hot reload:
```bash
cd MovieApp
dotnet watch run
```
Add a migration (after changing models):
```bash
cd MovieApp
dotnet ef migrations add Name && dotnet ef database update
```
(Install tool if needed: `dotnet tool install --global dotnet-ef`)

