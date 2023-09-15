FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SampleApi.WebAPI/SampleApi.WebAPI.csproj", "SampleApi.WebAPI/"]
RUN dotnet restore "SampleApi.WebAPI/SampleApi.WebAPI.csproj"
COPY . .
WORKDIR "/src/SampleApi.WebAPI"
RUN dotnet build "SampleApi.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleApi.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleApi.WebAPI.dll"]
