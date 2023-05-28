FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SuperPlan/SuperPlan.csproj", "SuperPlan/"]
RUN dotnet restore "SuperPlan/SuperPlan.csproj"
COPY . .
WORKDIR "/src/SuperPlan"
RUN dotnet build "SuperPlan.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SuperPlan.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SuperPlan.dll"]
