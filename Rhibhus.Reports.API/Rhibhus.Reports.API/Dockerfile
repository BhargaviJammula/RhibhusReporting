# Use the .NET 9 runtime image
# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime

# Set working directory inside the container
WORKDIR /app

# Copy prebuilt published app from local Release folder to container
COPY ./bin/Release/net9.0/publish/ ./

# Set the startup command
ENTRYPOINT ["dotnet", "Rhibhus.Reports.API.dll"]
