FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["AdvancedEntityFrameWorkCore/AdvancedEntityFrameWorkCore.csproj", "AdvancedEntityFrameWorkCore/"]
RUN dotnet restore "AdvancedEntityFrameWorkCore/AdvancedEntityFrameWorkCore.csproj"
COPY . .
WORKDIR "/src/AdvancedEntityFrameWorkCore"
RUN dotnet build "AdvancedEntityFrameWorkCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdvancedEntityFrameWorkCore.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdvancedEntityFrameWorkCore.dll"]
