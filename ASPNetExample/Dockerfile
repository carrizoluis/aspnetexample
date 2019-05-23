#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-nanoserver-1803 AS build
WORKDIR /src
COPY ["ASPNetExample/ASPNetExample.csproj", "ASPNetExample/"]
RUN dotnet restore "ASPNetExample/ASPNetExample.csproj"
COPY . .
WORKDIR "/src/ASPNetExample"
RUN dotnet build "ASPNetExample.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ASPNetExample.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ASPNetExample.dll"]