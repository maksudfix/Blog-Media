# Blog Media

> A full-stack, responsive blogging platform built with ASP.NET Core MVC, Entity Framework Core, and SQL Server. The application features authentication, role-based access control, category-based filtering, post management, commenting, and custom Razor Tag Helpers.

## Features

* Authentication & Authorization

  * ASP.NET Core Identity integration
  * Role-based access control with `Admin` and `User` roles
  * Login, registration, and access-denied handling

* Role-Based Access Control

  * Administrative access for content management
  * Protected routes and authorization policies

* Blog Post Management

  * Create, read, update, and delete posts
  * Dedicated post details page
  * ViewModel-based form handling

* Category Filtering

  * Browse posts by category
  * Supports categories such as `Technology`, `Health`, and `Lifestyle`

* Interactive Comments

  * Users can participate in discussions through post comments
  * Comments are displayed within the relevant post details page

* Automated Data Seeding

  * Automatically creates required roles
  * Seeds a default administrator account for development

* Custom Razor Tag Helper

  * `RemoveHtmlTagHelper` removes HTML markup when rendering clean post summaries

* Responsive UI

  * Razor Views with Bootstrap and custom CSS
  * Responsive layouts for different screen sizes
    


##  Architecture

Blog Media follows the Model-View-Controller (MVC) architectural pattern.

<img src="images/Blog-Media png" alt="Blog Media Architecture" width="500"><img width="900" height="500" alt="image" src="https://github.com/user-attachments/assets/f19ba28b-b17b-43b1-b0b1-c206a7f98c9b" />

### Architecture Overview

**Controllers**

Handle HTTP requests, application flow, authorization, and interaction between Views, ViewModels, Identity, and the database.

**ViewModels**

Provide dedicated models for operations such as registration, login, post creation, and editing. This helps avoid binding domain entities directly to user input.

**Entity Framework Core**

Provides database access through `AppDbContext` and manages the application's data model and migrations.

**ASP.NET Core Identity**

Handles user authentication, authorization, roles, password management, and account-related functionality.

**Razor Views**

Provide the presentation layer using Razor, HTML, CSS, JavaScript, Bootstrap, and custom UI components.

## Project Structure

Blog Media/
├── Controllers/
│   ├── AuthController.cs
│   ├── HomeController.cs
│   └── PostController.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Helpers/
│   └── RemoveHtmlTagHelper.cs
│
├── Models/
│   ├── ViewModels/
│   │   ├── EditViewModel.cs
│   │   ├── LoginViewModel.cs
│   │   ├── PostViewModel.cs
│   │   └── RegisterViewModel.cs
│   ├── Category.cs
│   ├── Comment.cs
│   └── Post.cs
│
├── Views/
│   ├── Auth/
│   │   ├── Login.cshtml
│   │   ├── Register.cshtml
│   │   └── AccessDenied.cshtml
│   ├── Home/
│   ├── Post/
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Delete.cshtml
│   │   ├── Detail.cshtml
│   │   └── Index.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _Navbar.cshtml
│
├── Migrations/
├── appsettings.json
├── Program.cs
└── Blog Media.csproj


## Tech Stack

| Technology                  | Purpose                          |
| --------------------------- | -------------------------------- |
| **ASP.NET Core MVC**        | Web application framework        |
| **C#**                      | Application programming language |
| **Entity Framework Core**   | ORM and database access          |
| **SQL Server / LocalDB**    | Relational database              |
| **ASP.NET Core Identity**   | Authentication and authorization |
| **Razor Views**             | Server-side UI rendering         |
| **Bootstrap**               | Responsive UI components         |
| **HTML / CSS / JavaScript** | Frontend development             |


### Prerequisites

Make sure the following are installed:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQL Server, SQL Server Express, or SQL Server LocalDB
- Visual Studio 2026 or VS Code with the C# Dev Kit
- Entity Framework Core CLI (`dotnet-ef`)

> **Target Framework:** `.NET 10`
>
> **ASP.NET Core Identity:** `10.0.0`
>
> **Entity Framework Core:** `10.0.0`


### 1. Clone the Repository

```bash
git clone https://github.com/maksudfix/Blog-Media
cd Blog-Media
```

### 2. Configure the Database

Update the connection string in `appsettings.json` according to your SQL Server environment.

  "ConnectionStrings": {
    "DefaultConnection": "Server=HP-TREX\\SQLEXPRESS; Database = blogmedia_db; Trusted_Connection = True; TrustServerCertificate = True;"
  }

> For production environments, use environment variables, User Secrets, Azure Key Vault, or another secure configuration provider rather than committing sensitive connection information to source control.

### 3. Apply Entity Framework Migrations

**Database & Migrations**
To create a new migration:
*Add-Migration Initial*
To apply migrations:
*Update-Database*
Run the following CLI command to update your local database:
*dotnet ef database update*

### 4. Run the Application
dotnet run
The application will display its local URL in the terminal. Open that URL in your browser.
For example:
https://localhost:7118

## Default Development Credentials

For development/demo purposes, the application seeds a default administrator account during startup.

| Field    |  Value            |
| ---------|-----------------  |
| Role     | `Admin`           |
| Email    | `admin@gmail.com` |
| Password | `admin`           |


## 🎯 Project Goals

Blog Media was built to demonstrate practical experience with:

* ASP.NET Core MVC application development
* C# and object-oriented programming
* Entity Framework Core
* SQL Server database integration
* Authentication and authorization
* Role-based access control
* CRUD operations
* ViewModels and model binding
* Razor Views
* Custom Tag Helpers
* Database migrations
* Secure application configuration

## Future Improvements

* **CI/CD & Testing**: Add GitHub Actions automated deployment pipelines, unit tests, and integration test coverage.
* **Architecture & Clean Code**: Refactor controllers to follow SOLID principles, add centralized exception handling, and implement structured logging.
* **Performance & Scale**: Implement Redis caching, database query optimizations, and pagination for large datasets.
* **Enhanced Authoring**: Upgrade to a rich-text WYSIWYG editor with AI-assisted drafting, summarizing, and proofreading.
* **UI/UX & Discovery**: Modernize dashboard design and expand content categories for better navigation.

## Author
Maksud Mubin (Trex Development)
https://github.com/maksudfix

