Steps:

create .env file with one line:  
OPENAI_API_KEY=....  

Terminal no. 1:
docker build -t python311_langchain_javonet ./python311_langchain_javonet  
docker run -it -p 8080:8080 --name python_node --env-file .env python311_langchain_javonet  

Terminal no. 2:
docker build -t python311_langchain_webservice ./python311_langchain_webservice  
docker run -it -p 8083:8080 --name python_webservice --env-file .env python311_langchain_webservice

Terminal no. 3:
docker build -t netcore60_bankscoring_javonet ./netcore60_bankscoring_javonet  
docker run -it -p 8081:8080 --name netcore_node netcore60_bankscoring_javonet  

Terminal no. 4:
docker build -t netcore60_bankscoring_webservice ./netcore60_bankscoring_webservice
docker run -it -p 8082:80 --name netcore_webservice netcore60_bankscoring_webservice


