# AgentText Web Application

## Overview
The AgentText Web Application is a .NET 8 web application that allows users to submit questions and receive responses from the AgentText Invoke agent. This application is designed to provide a seamless interaction between users and the agent, facilitating easy access to information.

## Project Structure
The project is organized as follows:

```
AgentTextWebApp
├── src
│   ├── AgentTextWebApp.csproj        # Project file for the .NET application
│   ├── Program.cs                     # Entry point of the application
│   ├── Startup.cs                     # Configures services and request pipeline
│   ├── Controllers
│   │   └── QuestionsController.cs     # Handles HTTP requests related to questions
│   ├── Services
│   │   └── AgentTextService.cs        # Interacts with the AgentText Invoke agent
│   ├── Models
│   │   └── QuestionRequest.cs         # Defines the structure of the question request
│   └── appsettings.json               # Configuration settings for the application
└── README.md                          # Documentation for the project
```

## Getting Started

### Prerequisites
- .NET 8 SDK
- A suitable IDE or text editor (e.g., Visual Studio Code)

### Installation
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd AgentTextWebApp/src
   ```
3. Restore the project dependencies:
   ```
   dotnet restore
   ```

### Running the Application
To run the application, use the following command:
```
dotnet run
```
The application will start and listen for incoming requests.

### API Endpoints
- **POST /api/questions**: Accepts a question from the user and returns a response from the AgentText Invoke agent.

### Configuration
Update the `appsettings.json` file with the necessary configuration settings, such as connection strings and API keys required to interact with the AgentText Invoke agent.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.