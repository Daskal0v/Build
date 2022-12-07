#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS build
WORKDIR /src
COPY ["Build.Web/Build.Web.csproj", "Build.Web/"]
RUN dotnet restore "Build.Web/Build.Web.csproj"
COPY . .
WORKDIR "/src/Build.Web"
RUN dotnet build "Build.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Build.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Build.Web.dll"]