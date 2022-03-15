FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base

COPY bin/Release/netcoreapp3.1 app/

ENTRYPOINT ["dotnet", "app/API.dll"]