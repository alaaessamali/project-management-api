# Project & Task Management API

A scalable backend API built using ASP.NET Core Web API following Clean Architecture principles.
The system allows authenticated users to manage projects and tasks efficiently using secure JWT authentication.

## 🚀 Technologies Used
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- SQL Server
- JWT Authentication
- Clean Architecture
- Swagger / OpenAPI

## 🏗️ Project Architecture
ProjectManagement.API
ProjectManagement.Application
ProjectManagement.Domain
ProjectManagement.Infrastructure

API	=>Controllers, Middleware, Authentication
Application=>	DTOs, Interfaces
Domain=>	Entities, Enums
Infrastructure=>	DbContext, Services

🔐 Authentication
JWT Authentication is implemented with:
User Registration
User Login
Protected APIs using JWT Token

🛡️ Implemented Concepts
Clean Architecture
Dependency Injection
DTO Pattern
Validation
Global Exception Handling
Enum-based Status
Swagger Documentation
