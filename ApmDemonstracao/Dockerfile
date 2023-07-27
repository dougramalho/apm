# Baseado na imagem oficial do ASP.NET 6.0 da Microsoft
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

# Use a imagem do SDK para construir a aplicação
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copia o .csproj e restaura as dependências
COPY ["ApmDemonstracao/ApmDemonstracao.csproj", "ApmDemonstracao/"]
RUN dotnet restore "ApmDemonstracao/ApmDemonstracao.csproj"

# Copia o resto do projeto e constrói a aplicação
COPY . .
WORKDIR "/src/ApmDemonstracao"
RUN dotnet build "ApmDemonstracao.csproj" -c Development -o /app/build

FROM build AS publish
RUN dotnet publish "ApmDemonstracao.csproj" -c Development -o /app/publish

# Cria a imagem final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApmDemonstracao.dll"]
