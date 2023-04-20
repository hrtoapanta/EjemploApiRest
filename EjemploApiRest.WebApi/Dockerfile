#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["EjemploApiRest.WebApi/EjemploApiRest.WebApi.csproj", "EjemploApiRest.WebApi/"]
COPY ["EjemploApiRest.Services/EjemploApiRest.Services.csproj", "EjemploApiRest.Services/"]
COPY ["EjemploApiRest/EjemploApiRest.Abtractions/EjemploApiRest.Abtractions.csproj", "EjemploApiRest/EjemploApiRest.Abtractions/"]
COPY ["EjemploApiRest/EjemploApiRest.Aplication/EjemploApiRest.Aplication.csproj", "EjemploApiRest/EjemploApiRest.Aplication/"]
COPY ["EjemploApiRest/EjemploApiRest.Entities/EjemploApiRest.Entities.csproj", "EjemploApiRest/EjemploApiRest.Entities/"]
COPY ["EjemploApiRest/EjemploApiRest.Repository/EjemploApiRest.Repository.csproj", "EjemploApiRest/EjemploApiRest.Repository/"]
COPY ["EjemploApiRest/EjemploApiRest.DataAccess/EjemploApiRest.DataAccess.csproj", "EjemploApiRest/EjemploApiRest.DataAccess/"]
RUN dotnet restore "EjemploApiRest.WebApi/EjemploApiRest.WebApi.csproj"
COPY . .
WORKDIR "/src/EjemploApiRest.WebApi"
RUN dotnet build "EjemploApiRest.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EjemploApiRest.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EjemploApiRest.WebApi.dll"]