# Project Name  - Agent4Devops

## Main person 
- David,
- dzhou026@uottawa.ca

### Team members : 
- John Requio,
- jasonau003


### Project Objectives:
- Create multi-agent asistant system for help line website based on Azure AI agents and machine leaning

### Software architecture and compnents
- front end: web-based GUI for accepting question and display the answer
- Middle tier: Azure agent system that provide API for getting request and returning awswers. 
-- Classifier agent: pre-trainined AutoML model for text classifiction to determine types of callingissue such as legal, mental, alcohoic
-- RAG agent: LLM model with RAG on client quesion-answer dataset
-- Orchestrator agent: merge the response from the two agents and synthesize reply
-Backend tier: Large langugae model and vector database

### code
- Front end: .net based webpage
- Middle tire: AI foundry
--Backend: GPT-o4 mini/Vector store for client data set

 

