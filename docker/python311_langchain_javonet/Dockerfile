FROM python:3.11

RUN apt-get update

WORKDIR /usr/app
COPY ./ ./

RUN pip install langchain
RUN pip install openai

EXPOSE 8080

CMD ["/usr/app/JavonetTCPServer"]