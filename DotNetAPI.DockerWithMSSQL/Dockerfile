# Use the .NET 8.0 SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project file and restore any dependencies
COPY ["DotNetAPI.DockerWithMSSQL.csproj", "."]
RUN dotnet restore "DotNetAPI.DockerWithMSSQL.csproj"

# Copy the rest of the code and build the application
COPY . .
RUN dotnet build "DotNetAPI.DockerWithMSSQL.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "DotNetAPI.DockerWithMSSQL.csproj" -c Release -o /app/publish

# Use the .NET 8.0 runtime image for running the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=publish /app/publish .

# Expose the port the app runs on
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "DotNetAPI.DockerWithMSSQL.dll"]
