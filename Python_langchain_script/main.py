from langchain.llms import OpenAI

if __name__ == '__main__':
    llm = OpenAI()
    question = "What can i do in Warsaw?"
    response = llm.invoke(question)
    print(response)

