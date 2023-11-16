from langchain.llms import OpenAI
import flask
from flask import request
import logging

log = logging.getLogger('werkzeug')
log.setLevel(logging.ERROR)

app = flask.Flask(__name__)

@app.route('/api/invoke_llm', methods=['Get'])
def invoke_llm():
    prompt = request.args.get('prompt')
    llm = OpenAI()
    response = llm.invoke(prompt)
    return response


if __name__ == '__main__':
   app.run(host="0.0.0.0", port=8080, debug=True)

