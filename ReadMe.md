\# DotnetCloudMicroservices



This project showcases a secure, cloud-native microservices architecture built with .NET Core 6, Docker, Kubernetes, and Azure DevOps. It reflects real-world enterprise modernization work I've led—transforming legacy systems into scalable, secure platforms.



\## 🔧 Tech Stack

\- \*\*Backend\*\*: ASP.NET Core 6, RESTful APIs

\- \*\*Security\*\*: JWT, Azure AD, OAuth 2.0

\- \*\*Containerization\*\*: Docker

\- \*\*Orchestration\*\*: Kubernetes (YAML configs included)

\- \*\*CI/CD\*\*: Azure DevOps Pipelines

\- \*\*Testing\*\*: xUnit, Moq

\- \*\*Frontend\*\*: Lightweight ReactJS dashboard (optional extension)



\## 📦 Microservices Included

\- \*\*ProductService\*\*: Secure API for managing product data

\- \*\*AuthService\*\*: Azure AD integration for identity and access

\- \*\*Gateway\*\*: API routing and token validation (optional)



\## 🚀 Features

\- Secure endpoints with JWT and Azure AD

\- Dockerfile for containerized deployment

\- Azure DevOps pipeline for automated build and push

\- Unit tests for business logic

\- Scalable architecture for cloud-native environments



\## 🧪 How to Run Locally

```bash

\# Build and run the ProductService

cd ProductService

dotnet build

dotnet run

