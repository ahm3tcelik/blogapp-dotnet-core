# Migrate
$- cd ./src/Infrastructure/Persistence
$- dotnet ef migrations add  <name> --startup-project ../../API
$- dotnet ef database update