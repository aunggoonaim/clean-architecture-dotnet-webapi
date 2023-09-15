FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OfficeBoardApi.WebAPI/OfficeBoardApi.WebAPI.csproj", "OfficeBoardApi.WebAPI/"]
RUN dotnet restore "OfficeBoardApi.WebAPI/OfficeBoardApi.WebAPI.csproj"
COPY . .
WORKDIR "/src/OfficeBoardApi.WebAPI"
RUN dotnet build "OfficeBoardApi.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OfficeBoardApi.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OfficeBoardApi.WebAPI.dll"]
