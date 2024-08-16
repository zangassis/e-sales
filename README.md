# 🛒 e-Sales

This project contains a sample ASP.NET Core app. This app is an example of the article I produced for the Telerik Blog (telerik.com/blogs)

This ASP.NET Core solution is built following the principles of **Domain-Driven Design (DDD)**. It is structured into three main layers: Domain, Application, and Infrastructure.

## 🏗️ Project Structure

### 1. Commission.API 🌐
- This layer handles all the **API** operations.
- Responsible for exposing endpoints for **external communication**.
- Implements **controllers** that interact with the domain layer.

### 2. Commission.Domain 📚
- This is the **heart** of the application, where the **business logic** resides.
- Contains **entities**, **value objects**, and **domain services**.
- Implements the core logic that drives the **Commission** domain.

### 3. Commission.Infrastructure 🛠️
- Provides the **implementation** for data persistence, repositories, and external services.
- Manages **database connections**, **migrations**, and other infrastructure concerns.

## 🛠️ Getting Started

1. **Clone** the repository:
    ```bash
    git clone https://github.com/zangassis/e-sales.git
    ```

2. **Navigate** to the project folder:
    ```bash
    cd e-sales
    ```

3. **Build** the solution:
    ```bash
    dotnet build
    ```

4. **Run** the API project:
    ```bash
    cd Commission.API
    dotnet run
    ```

## 📦 Dependencies

- **ASP.NET Core** for the web API.
- **Entity Framework Core** for data access.

## 🌟 Key Features

- **Domain-Driven Design** for a scalable and maintainable architecture.
- **Separation of concerns** with distinct layers for API, Domain, and Infrastructure.
- **Flexible and modular** design, making it easy to extend and maintain.

## 📜 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for more details.
