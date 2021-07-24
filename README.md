# basic-build-metadata
General information about build metadata

Using tutorial from [here](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio-code).

Currently, done with basic functionality.

# Setup
## Initializing DB
Run commands:
1. `dotnet tool install --global dotnet-ef`
2. `dotnet add package Microsoft.EntityFrameworkCore.Design`
3. `dotnet ef migrations add InitialCreate`
4. `dotnet ef database update`

# TODO
## For Production
2. Create DTO to pass back and forth to show the infrastructure and ability to limit data appropriately for results of certain endpoints. This is in the tutorial.
