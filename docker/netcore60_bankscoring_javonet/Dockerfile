FROM mcr.microsoft.com/dotnet/runtime:6.0

RUN apt-get update

WORKDIR /usr/app
COPY ./ ./

EXPOSE 8080

CMD ["/usr/app/JavonetTCPServer"]