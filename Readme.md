Steps:


cd docker
create .env file with one line:
OPENAI_API_KEY=....
docker build -t python311_langchain_javonet ./python311_langchain_javonet
docker build -t netcore60_bankscoring_javonet ./netcore60_bankscoring_javonet
docker run -it -p 8080:8080 --name python_node --env-file .env python311_langchain_javonet
docker run -it -p 8081:8080 --name netcore_node netcore60_bankscoring_javonet