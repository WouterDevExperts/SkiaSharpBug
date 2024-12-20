FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SkiaSharpBug/SkiaSharpBug.csproj", "SkiaSharpBug/"]
RUN dotnet restore "SkiaSharpBug/SkiaSharpBug.csproj"
COPY . .
WORKDIR "/src/SkiaSharpBug"
RUN dotnet build "SkiaSharpBug.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SkiaSharpBug.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SkiaSharpBug.dll"]