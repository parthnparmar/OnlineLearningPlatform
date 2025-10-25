# EduVerse - Technical Documentation

## Table of Contents
1. [Architecture Overview](#architecture-overview)
2. [Database Design](#database-design)
3. [API Endpoints](#api-endpoints)
4. [Frontend Components](#frontend-components)
5. [Styling Guide](#styling-guide)
6. [Configuration](#configuration)
7. [Development Guidelines](#development-guidelines)
8. [Troubleshooting](#troubleshooting)

## Architecture Overview

### MVC Pattern
The application follows the Model-View-Controller (MVC) architectural pattern:

- **Models**: Data entities and business logic
- **Views**: User interface and presentation layer
- **Controllers**: Handle user input and coordinate between models and views

### Technology Stack
- **Framework**: ASP.NET Core 9.0 MVC
- **ORM**: Entity Framework Core
- **Database**: SQL Server
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap 5
- **Package Manager**: NuGet

## Database Design

### Entity Relationship Diagram

```
User (1) -----> (M) Enrollment (M) <----- (1) Course
  |                                           |
  |                                           |
  v                                           v
UserProgress (M)                         Lesson (M)
                                             |
                                             v
                                         Quiz (1)
                                             |
                                             v
                                       Question (M)
                                             |
                                             v
                                        Answer (M)
```

### Core Entities

#### User
```csharp
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
    public ICollection<UserProgress> UserProgresses { get; set; }
}
```

#### Course
```csharp
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public string Level { get; set; }
    public int Duration { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<Lesson> Lessons { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
}
```

#### Lesson
```csharp
public class Lesson
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public LessonType Type { get; set; }
    public string VideoUrl { get; set; }
    public int Order { get; set; }
    public int Duration { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public Quiz Quiz { get; set; }
}
```

## API Endpoints

### Course Management

#### GET /Courses
- **Description**: Retrieve all courses
- **Response**: List of courses with basic information
- **View**: `Views/Courses/Index.cshtml`

#### GET /Courses/Details/{id}
- **Description**: Get detailed course information
- **Parameters**: `id` (int) - Course ID
- **Response**: Course details with lessons
- **View**: `Views/Courses/Details.cshtml`

#### GET /Courses/Enroll/{id}
- **Description**: Show course enrollment page
- **Parameters**: `id` (int) - Course ID
- **View**: `Views/Courses/Enroll.cshtml`

### Dashboard

#### GET /Dashboard
- **Description**: User dashboard with learning statistics
- **Authentication**: Required
- **View**: `Views/Dashboard/Index.cshtml`

#### GET /Dashboard/MyCourses
- **Description**: User's enrolled courses
- **Authentication**: Required
- **View**: `Views/Dashboard/MyCourses.cshtml`

#### GET /Dashboard/Profile
- **Description**: User profile management
- **Authentication**: Required
- **View**: `Views/Dashboard/Profile.cshtml`

### Authentication

#### GET /Auth/Login
- **Description**: Login page
- **View**: `Views/Auth/Login.cshtml`

#### POST /Auth/Login
- **Description**: Process user login
- **Parameters**: Email, Password

#### GET /Auth/Register
- **Description**: Registration page
- **View**: `Views/Auth/Register.cshtml`

#### POST /Auth/Register
- **Description**: Process user registration
- **Parameters**: Name, Email, Password, ConfirmPassword

## Frontend Components

### Layout Structure

#### Main Layout (`_Layout.cshtml`)
```html
<!DOCTYPE html>
<html>
<head>
    <!-- Meta tags, CSS, fonts -->
</head>
<body>
    <nav class="navbar">
        <!-- Navigation menu -->
    </nav>
    
    <main>
        @RenderBody()
    </main>
    
    <footer>
        <!-- Footer content -->
    </footer>
    
    <!-- Scripts -->
</body>
</html>
```

### CSS Architecture

#### CSS Variables (`:root`)
```css
:root {
    --primary-color: #7c3aed;
    --secondary-color: #06b6d4;
    --accent-color: #f59e0b;
    --dark-bg: #0f0f23;
    --card-bg: #1a1a2e;
    --text-light: #f1f5f9;
    --text-gray: #f1f5f9;
}
```

#### Component Classes
- `.hero` - Hero section styling
- `.card` - Card component with dark theme
- `.course-card` - Specific styling for course cards
- `.dashboard-sidebar` - Dashboard navigation sidebar
- `.feature-icon` - Icon containers with gradients

## Styling Guide

### Color Palette

#### Primary Colors
- **Purple**: `#7c3aed` - Primary actions, branding
- **Teal**: `#06b6d4` - Secondary elements, info
- **Orange**: `#f59e0b` - Accents, warnings

#### Semantic Colors
- **Success**: `#10b981` - Completed items, positive actions
- **Warning**: `#f59e0b` - Attention items, warnings
- **Danger**: `#ef4444` - Errors, critical actions
- **Info**: `#06b6d4` - Informational content

#### Text Colors
- **Primary Text**: `#f1f5f9` - Main content
- **Secondary Text**: `#e2e8f0` - Supporting content
- **Muted Text**: `#94a3b8` - Less important content

### Typography

#### Font Family
```css
font-family: 'Inter', -apple-system, BlinkMacSystemFont, sans-serif;
```

#### Font Weights
- **Light**: 300
- **Regular**: 400
- **Medium**: 500
- **Semibold**: 600
- **Bold**: 700
- **Extrabold**: 800

### Component Guidelines

#### Buttons
```css
.btn-primary {
    background: linear-gradient(135deg, #f59e0b 0%, #ef4444 100%);
    border: none;
    padding: 12px 30px;
    border-radius: 50px;
    font-weight: 600;
}
```

#### Cards
```css
.card {
    background: var(--card-bg);
    border: 1px solid rgba(255, 255, 255, 0.1);
    border-radius: 20px;
    padding: 2rem;
}
```

## Configuration

### Database Connection
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=OnlineLearningPlatform;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

### Application Settings
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

### Entity Framework Configuration
```csharp
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)
           .ConfigureWarnings(warnings => 
               warnings.Ignore(RelationalEventId.PendingModelChangesWarning)));
```

## Development Guidelines

### Code Structure

#### Controllers
- Keep controllers thin, delegate business logic to services
- Use async/await for database operations
- Implement proper error handling
- Follow RESTful conventions

#### Models
- Use data annotations for validation
- Implement navigation properties for relationships
- Keep models focused on data representation

#### Views
- Use strongly-typed views with models
- Implement responsive design principles
- Follow accessibility guidelines
- Use semantic HTML elements

### Best Practices

#### Performance
- Use async operations for database calls
- Implement proper caching strategies
- Optimize images and static assets
- Minimize CSS and JavaScript files

#### Security
- Validate all user inputs
- Use parameterized queries (EF Core handles this)
- Implement proper authentication and authorization
- Sanitize output to prevent XSS

#### Maintainability
- Follow SOLID principles
- Use meaningful variable and method names
- Write comprehensive comments
- Implement unit tests

## Troubleshooting

### Common Issues

#### Database Connection Issues
```bash
# Check connection string
# Verify SQL Server is running
# Run migrations
dotnet ef database update
```

#### Build Errors
```bash
# Clean and rebuild
dotnet clean
dotnet build
```

#### Migration Issues
```bash
# Remove last migration
dotnet ef migrations remove

# Add new migration
dotnet ef migrations add MigrationName

# Update database
dotnet ef database update
```

#### CSS Not Loading
- Check file paths in `_Layout.cshtml`
- Verify static files middleware is configured
- Clear browser cache

#### JavaScript Errors
- Check browser console for errors
- Verify script references in layout
- Ensure jQuery is loaded before other scripts

### Performance Issues

#### Slow Database Queries
- Add appropriate indexes
- Use Include() for related data
- Implement pagination for large datasets

#### Large Page Load Times
- Optimize images (use WebP format)
- Minify CSS and JavaScript
- Enable compression
- Use CDN for static assets

### Debugging Tips

#### Entity Framework
```csharp
// Enable sensitive data logging in development
options.EnableSensitiveDataLogging();
options.EnableDetailedErrors();
```

#### Logging
```csharp
// Add logging to controllers
private readonly ILogger<HomeController> _logger;

_logger.LogInformation("User accessed course {CourseId}", id);
```

## Deployment Considerations

### Production Configuration
- Use production connection strings
- Enable HTTPS redirection
- Configure proper error handling
- Set up health checks

### Environment Variables
```bash
ASPNETCORE_ENVIRONMENT=Production
ConnectionStrings__DefaultConnection="Production connection string"
```

### IIS Deployment
- Install ASP.NET Core Hosting Bundle
- Configure application pool
- Set proper permissions
- Enable detailed errors for troubleshooting

---

This documentation provides comprehensive technical details for developers working on the EduVerse platform. For additional support, refer to the README.md file or contact the development team.