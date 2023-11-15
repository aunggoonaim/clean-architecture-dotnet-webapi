FROM mcr.microsoft.com/dotnet/aspnet:8.0.0-jammy AS base
RUN apt install tzdata
ENV TZ=Asia/Bangkok
ENV LANG th_TH.UTF-8
ENV LANGUAGE ${LANG}
ENV LC_ALL ${LANG}
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0.100-jammy AS build
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
