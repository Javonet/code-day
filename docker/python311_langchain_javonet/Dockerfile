FROM python:3.11

RUN apt-get update

RUN pip install langchain
RUN pip install openai

WORKDIR /usr/app
COPY ./ ./

EXPOSE 8080

CMD ["/usr/app/JavonetTCPServer"]