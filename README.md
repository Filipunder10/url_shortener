# URL Shortener
## Setup
### Environment
Make sure you have dotnet 8.0 installed and configured. Also download the following packages with NuGet or like this:
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```
### Database
To set up the database schema using Entity Framework Core migrations, use the following:
```bash
# Only needed once (if not already installed)
dotnet tool install --global dotnet-ef

dotnet ef database update
```

## Running
Finally, build and run the application with:
```bash
dotnet build
dotnet run
```
