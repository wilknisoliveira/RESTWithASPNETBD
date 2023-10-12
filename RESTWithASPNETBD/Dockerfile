#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Create a base image with aspnet 6 and expose in the ports 80 and 443
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Mount a image called 'build'
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RESTWithASPNETBD/RESTWithASPNETBD.csproj", "RESTWithASPNETBD/"]
RUN dotnet restore "RESTWithASPNETBD/RESTWithASPNETBD.csproj"
COPY . .
WORKDIR "/src/RESTWithASPNETBD"
RUN dotnet build "RESTWithASPNETBD.csproj" -c Release -o /app/build

# Use the build image and publish the project
FROM build AS publish
RUN dotnet publish "RESTWithASPNETBD.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Generate the final image with fewer layers
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RESTWithASPNETBD.dll"]