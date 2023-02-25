FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app


COPY *.sln ./
COPY BlogHS.API/*.csproj ./BlogHS.API/
COPY BlogHS.Domain/*.csproj ./BlogHS.Domain/
COPY BlogHS.Infrastructure/*.csproj ./BlogHS.Infrastructure/
RUN dotnet restore


COPY . ./
RUN dotnet publish BlogHS.API -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "BlogHS.API.dll"]