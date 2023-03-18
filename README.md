# Clean Web API template (ASP .NET Core)
Simple clean web API template with setup for postgresql. Template is using:
- Entity Framework with Postgresql
- NUnit
- Automapper
- MediatoR
- Moq
- SwaggerUI

Template is based on [CleanArchitecture](https://github.com/jasontaylordev/CleanArchitecture).


# Using dotnet EF
To install entity framework globaly use:
```bash
dotnet tool install --global dotnet-ef
```
After installing you can use it to generate new migration via:
```bash
dotnet ef migrations add "MigrationName" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations
```

Aside for creating new migrations you can also remove the last one by using remove command:
```bash
dotnet ef migrations remove --project src\Infrastructure
```

