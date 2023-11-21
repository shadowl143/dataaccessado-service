FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
COPY . ./
RUN dotnet restore "/app/Axity.DataAccessAdo.Api/Axity.DataAccessAdo.Api.csproj"
COPY . ./
RUN dotnet publish "/app/Axity.DataAccessAdo.Api/Axity.DataAccessAdo.Api.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Axity.DataAccessAdo.Api.dll"]