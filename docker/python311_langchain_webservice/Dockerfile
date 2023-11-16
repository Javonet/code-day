FROM python:3.11

RUN apt-get update

RUN pip install langchain
RUN pip install openai
RUN pip install flask

WORKDIR /usr/app
COPY ./langchain_ws.py ./

EXPOSE 8080

CMD ["python3", "/usr/app/langchain_ws.py"]