# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY WebUI/*.csproj ./WebUI/
COPY MyApp/*.csproj ./MyApp/
RUN dotnet restore ./WebUI/WebUI.csproj

# Copy the rest of the code
COPY . .

# Build the project
RUN dotnet publish WebUI/WebUI.csproj -c Release -o out

# Use ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port and run the app
EXPOSE 80
ENTRYPOINT ["dotnet", "WebUI.dll"]