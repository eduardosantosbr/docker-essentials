FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0.3" description="Aplicação ASP .NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "docker-essentials.dll"]