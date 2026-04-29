# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Project file copy karein (Space ka dhyan rakhte huay)
COPY *.csproj ./
RUN dotnet restore

# Baki sara code copy aur publish
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime Stage
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .

# Entry point (Yahan wo naam likhein jo aapki .dll file ka hai)
ENTRYPOINT ["dotnet", "Mid project.dll"]