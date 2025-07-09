# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy all files and build release
COPY . ./
RUN dotnet publish -c Release -o out

# Use the runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expose the port (Render will assign one)
ENV ASPNETCORE_URLS=http://+:$PORT
EXPOSE $PORT

# Run the app
ENTRYPOINT ["dotnet", "Chetra_Portfolio.dll"]
