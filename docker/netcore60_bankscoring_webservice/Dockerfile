FROM mcr.microsoft.com/dotnet/aspnet:6.0

RUN apt-get update

WORKDIR /usr/app
COPY ./ ./

EXPOSE 5000

CMD ["dotnet", "WebApi.dll"]