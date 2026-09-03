# Blog Media

A full-stack, responsive blogging platform built with ASP.NET Core MVC, Entity Framework Core, SQL Server, HTML, CSS and JavaScript, featuring - authentication, role-based authorization, category-based filtering, post management, and commenting for authenticated users.

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

<img src="images/Blog-Media-Structure.png" alt="Blog Media Project Structure" width="500"><img width="900" height="500" alt="image" src="https://github.com/user-attachments/assets/9364015f-e19a-4cd1-801a-73c930a683aa" />

## Prerequisites

Make sure the following are installed:

* [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* SQL Server, SQL Server Express, or SQL Server LocalDB
* Visual Studio 2026 or VS Code with the C# Dev Kit
* Entity Framework Core CLI (`dotnet-ef`)
> **Target Framework:** `.NET 10`
> **Install From Manage NutGet Packages:**
  Microsoft.AspNetCore.Identity.EntityFrameworkCore Version="10.0.0" 
  Microsoft.EntityFrameworkCore.SqlServer Version="10.0.0"
  Microsoft.EntityFrameworkCore.Tools" Version="10.0.0"


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

## Project Goals

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

**CI/CD & Testing**: Add GitHub Actions automated deployment pipelines, unit tests, and integration test coverage.
**Architecture & Clean Code**: Refactor controllers to follow SOLID principles, add centralized exception handling, and implement structured logging.
**Performance & Scale**: Implement Redis caching, database query optimizations, and pagination for large datasets.
**Enhanced Authoring**: Upgrade to a rich-text WYSIWYG editor with AI-assisted drafting, summarizing, and proofreading.
**UI/UX & Discovery**: Modernize dashboard design and expand content categories for better navigation.

## Author
Maksud Mubin (Trex Development)
https://github.com/maksudfix

