FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY CalcInvest/CalcInvest.API/CalcInvest.API.csproj CalcInvest/CalcInvest.API/

RUN dotnet restore CalcInvest/CalcInvest.API/CalcInvest.API.csproj

COPY . .

RUN dotnet publish CalcInvest/CalcInvest.API/CalcInvest.API.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "CalcInvest.API.dll"]

