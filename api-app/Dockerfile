FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

COPY . ./
RUN dotnet restore ./api-app/api-app.csproj
RUN dotnet publish -c Release -o out ./api-app/api-app.csproj


FROM mcr.microsoft.com/dotnet/aspnet as run-env
WORKDIR /App
COPY --from=build-env /App/out .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080
ENV ComPlusEnableDiagnostics=0

USER app

ENTRYPOINT ["dotnet", "api-app.dll"]