FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY . ./

RUN dotnet restore "Midproject.csproj"
RUN dotnet publish "Midproject.csproj" -c Release -o /out

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app

COPY --from=build /out .

ENTRYPOINT ["dotnet", "Midproject.dll"]