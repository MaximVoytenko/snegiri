# Этап 1: Сборка
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source


COPY . .
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app

COPY --from=build /app .

# Определяем том для внешних данных
VOLUME /app/data

# Указываем точку входа для приложения
ENTRYPOINT ["dotnet", "govno.dll"]

