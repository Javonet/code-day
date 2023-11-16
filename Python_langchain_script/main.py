from langchain.llms import OpenAI

if __name__ == '__main__':
    llm = OpenAI()
    prompt = "Say hello to my CodeDay Audience"
    response = llm.invoke(prompt)
    print(response)

