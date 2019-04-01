#FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
#WORKDIR /app
#EXPOSE 59518
#EXPOSE 44364

#publicación en producción login docker
#FROM microsoft/dotnet:2.1-sdk AS build
#WORKDIR /src
#COPY WebApiRestIntoNetCore_Sample/WebApiRestIntoNetCore_Sample.csproj WebApiRestIntoNetCore_Sample/
#RUN dotnet restore WebApiRestIntoNetCore_Sample/WebApiRestIntoNetCore_Sample.csproj
#COPY . .
#WORKDIR /src/WebApiRestIntoNetCore_Sample
#RUN dotnet build WebApiRestIntoNetCore_Sample.csproj -c Release -o /app

#FROM build AS publish
#RUN dotnet publish WebApiRestIntoNetCore_Sample.csproj -c Release -o /app

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "app/WebApiRestIntoNetCore_Sample.dll"]


#publicación local#
FROM microsoft/dotnet:2.1-sdk
WORKDIR /app
#EXPOSE 59518
EXPOSE 5000

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy and build everything else
COPY . ./
RUN dotnet publish -c Dev -o app

ENV ASPNETCORE_URLS=http://+:5000

ENTRYPOINT ["dotnet", "app/WebApiRestIntoNetCore_Sample.dll"]

#docker build -t aspnetapp .
#docker run -it --rm -p 5000:80 --name aspnetcore_sample aspnetapp

#docker run -d -name webapirestintonetcore_sample -p 80:5000 netcorelnx

#/*
#Siempre compilar desplegar docker en directorio root app y con permisos de usuario admin
#*/

#docker build -t webapirestintonetcore_sample-dev .
#run for console.
#docker run --rm -p 5000:500 webapirestintonetcore_sample-dev webapirestintonetcore_sample from Docker
#run interactive for VSCode.
# docker run --rm -it webapirestintonetcore_sample-dev:latest
#docker exec -it 1ba7fd6728e7 cmd
#docker run -v $(pwd):/src -it <container_name>