# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["services/catalog/Api/Category.Api.csproj", "services/catalog/Api/"]
COPY ["services/catalog/Application/Category.Application.csproj", "services/catalog/Application/"]
COPY ["events/Events.csproj", "events/"]
COPY ["framework/Core/DotMK.Framework.Core.csproj", "framework/Core/"]
COPY ["services/catalog/Domain/Category.Domain.csproj", "services/catalog/Domain/"]
COPY ["services/catalog/Infrastructure/Category.Infrastructure.csproj", "services/catalog/Infrastructure/"]
COPY ["framework/data/Persistence.NoSQL/DotMK.Framework.Persistence.Mongo.csproj", "framework/data/Persistence.NoSQL/"]
COPY ["framework/Infrastructure/DotMK.Framework.Infrastructure.csproj", "framework/Infrastructure/"]
RUN dotnet restore "./services/catalog/Api/Category.Api.csproj"
COPY . .
WORKDIR "/src/services/catalog/Api"
RUN dotnet build "./Category.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Category.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotMK.Catalog.Api.dll"]