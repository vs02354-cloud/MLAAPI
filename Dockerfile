FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["MLA.Portal.Api/MLA.Portal.Api.csproj", "MLA.Portal.Api/"]
COPY ["MLA.Portal.Application/MLA.Portal.Application.csproj", "MLA.Portal.Application/"]
COPY ["MLA.Portal.Domain/MLA.Portal.Domain.csproj", "MLA.Portal.Domain/"]
COPY ["MLA.Portal.Infrastructure/MLA.Portal.Infrastructure.csproj", "MLA.Portal.Infrastructure/"]
RUN dotnet restore "./MLA.Portal.Api/MLA.Portal.Api.csproj"

# Copy everything else and build
COPY . .
WORKDIR "/src/MLA.Portal.Api"
RUN dotnet build "./MLA.Portal.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MLA.Portal.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MLA.Portal.Api.dll"]
