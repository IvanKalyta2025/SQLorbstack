docker run --name pg \
 -e POSTGRES_DB=BMW \
 -e POSTGRES_USER=postgres \
 -e POSTGRES_PASSWORD=pass \
 -p 5432:5432 -d postgres:16

для запуска в орбстек

проверка контенера docker ps

dotnet ef database drop --force
dotnet ef migrations remove
dotnet ef migrations add Init
dotnet ef database update
