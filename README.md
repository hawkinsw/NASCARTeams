# NASCAR Teams

A small, play .NET MVC web application for tracking information about
NASCAR teams. Good for learning the basics of building a web app in .NET.

## Configuring .NET for Linux:

1. For Ubuntu 20.10, 
- Follow [these](https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu#2010-) instructions.

## Configuring Codium for .NET on Linux

1. Sideload the [omnisharp extension](https://github.com/OmniSharp/omnisharp-vscode).

## Configuring the Project:

1. First, add the required packages:
```
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
```
2. Register the packages
```
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.Extensions.Logging.Debug
```

## Documentation References

1. [Adding controllers and working with a database](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-5.0&tabs=visual-studio-code)

## Running the application locally

```
$ dotnet run watch
```

## License

Reuse under the GPL-3.0.
