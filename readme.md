# Clean Architecture Console Application .Net Core
Sample implementation of the Clean Architecture Principles with .NET Core by Console application. Use cases as central organizing structure, decoupled from frameworks and technology details. Built by small components that are developed and tested in isolation.
## Technologies
* NET Core 5 
* Entity Framework Core 5
* AutoMapper
* Serilog
* FluentValidation
* xUnit & Moq
* Docker
## Getting Started
### Dependencies

* Install the latest [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) Check the .NET Core SDK on .global.json


### Installing
* Clone project in your workspace

### Compile program
```
dotnet build
```
### Database Migrations

To use `dotnet-ef` for your migrations please add the following flags to your command (values assume you are executing from repository root)

* `--project src/Infrastructure` (optional if in this folder)


For example, to add a new migration from the root folder:

 `dotnet ef migrations add "SampleMigration" --project src\Infrastructure`

### Install migrations
```
dotnet ef database update
```

### Executing program
* How to run the program
* Step-by-step bullets
```
dotnet Run
```
## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### ConsoleApp

This layer with Console application based .Net Core 5. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only *Application.cs* should reference Infrastructure.

## Authors
Contributors names and contact info
ex. Dominique Pizzie  
ex. [@galydev](https://github.com/galydev)
## Version History
* Initial Release
## License
This project is licensed with the [MIT license](LICENSE).
