#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1803 AS build
WORKDIR /src
COPY ["Soundche - Den sande scooter/Soundche - Den sande scooter.fsproj", "Soundche - Den sande scooter/"]
RUN dotnet restore "Soundche - Den sande scooter/Soundche - Den sande scooter.fsproj"
COPY . .
WORKDIR "/src/Soundche - Den sande scooter"
RUN dotnet build "Soundche - Den sande scooter.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Soundche - Den sande scooter.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Soundche - Den sande scooter.dll"]