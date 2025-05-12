# Usa la imagen oficial de .NET para aplicaciones ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Usa la imagen oficial de .NET SDK para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MiAplicacion.csproj", "./"]
RUN dotnet restore "MiAplicacion.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet publish "MiAplicacion.csproj" -c Release -o /app/publish

# Configura la imagen final
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MiAplicacion.dll"]