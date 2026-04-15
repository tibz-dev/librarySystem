# Library System API

A simple ASP.NET Core Web API built using Clean Architecture principles.
This project demonstrates separation of concerns across a layered architecture for scalability and maintainability.

---

## Architecture

* Domain → Core entities
* Application → Business logic and use cases
* Infrastructure → Data access
* WebApi → Controllers and API endpoints

---

## Features

* Add books
* View all books
* Borrow books (with validation)
* Return books (with validation)

---

## Endpoints

* GET /api/books → Get all books
* POST /api/books → Add a book
* PUT /api/books/{id}/borrow → Borrow a book
* PUT /api/books/{id}/return → Return a book

---

## Tech Stack

* ASP.NET Core Web API
* C#
* Clean Architecture
* Swagger (API testing)

---

## Run the Project

1. Open the solution in Visual Studio
2. Run the project (F5)
3. Swagger UI will open automatically

---

In short my project showcases how to build a structured, scalable, and maintainable backend system using Clean Architecture.

---
