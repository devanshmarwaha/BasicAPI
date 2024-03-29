FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Development
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BasicAPI/BasicAPI.csproj", "BasicAPI/"]
RUN dotnet restore "BasicAPI/BasicAPI.csproj"
COPY . .
WORKDIR "/src/BasicAPI"
RUN dotnet build "BasicAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BasicAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BasicAPI.dll"]