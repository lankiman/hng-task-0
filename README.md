# HNG12 Backend - Public API

Welcome to the Stage 0 Backend task for HNG12! This project provides a public API that returns basic information in JSON format. The API responds with your registered email, the current datetime (in ISO 8601 format), and the GitHub URL of the project's codebase.

## Project Description

This is a simple API developed in C# that serves the following details when accessed:

- Your registered email address.
- The current datetime in UTC in ISO 8601 format (`yyyy-MM-ddTHH:mm:ssZ`).
- The GitHub URL for the project repository.

### Features
- **CORS Handling**: The API is configured to allow cross-origin requests.
- **Response Format**: All responses are returned in JSON format.
- **Fast Response Time**: The response time for the API is under 500ms.

## Setup Instructions

### Prerequisites
- [.NET SDK 9.0 or higher](https://dotnet.microsoft.com/download/dotnet) should be installed.
- A code editor such as [Visual Studio Code](https://code.visualstudio.com/) is recommended.

### Running Locally
```bash
1. Clone the repository to your local machine:
   `git clone https://github.com/yourusername/hng-task-0.git`
   `cd hng-task-0`

2. Restore project dependencies:
   `dotnet restore`

3. Run the application locally:
   `dotnet run`

   This will run the API on your local machine. By default, it will be accessible at `http://localhost:5000`.

4. Test the API by sending a GET request to the following endpoint:
   `http://localhost:5000`

   You should receive a JSON response with the following data:
   ```json
      {
        "email": "user@example.com",
        "current_datetime": "2025-01-30T09:30:00Z",
        "github_url": "https://github.com/user/project"
     }

## API Documentation

### Endpoint: `GET /`

This endpoint returns the following data:
{
  "email": "user@example.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/user/project" ### Example Usage
}
To get the response, simply send a GET request to the root endpoint (`/`).
[https://hng-task-0-production-8c99.up.railway.app](https://hng-task-0-production-8c99.up.railway.app)

## Backlink

This project was developed using C# as the backend language. If you are interested in hiring C# developers, check out the following link:
[HNG Tech - Hire C# Developers](https://hng.tech/hire/csharp-developers)

## Documentation

This repository contains the code for the Stage 0 Backend task of the HNG12 program. The goal of this project is to build a simple public API that returns basic information, such as your registered email, the current datetime in UTC format, and the GitHub URL for the project repository.

### Project Structure

- **Program.cs**: The main entry point for the application. It sets up the web API with routes and CORS handling.
- **appsettings.json**: Configuration file (if applicable in future updates).
- **README.md**: This documentation file with setup instructions and details about the API.

### Technologies Used

- **C#**: The programming language used to build the API.
- **.NET 9.0**: The framework used for building the web application.
- **JSON**: The response format for the API.

## Deployment

This API is deployed to Railway and is accessible at the following publicly available endpoint:

[https://hng-task-0-production-8c99.up.railway.app](https://hng-task-0-production-8c99.up.railway.app)

You can access the live version of the API by visiting the provided URL.

The API is configured to have a fast response time (less than 500ms), and it is CORS-compliant for cross-origin requests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

