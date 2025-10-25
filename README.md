# EduVerse - Online Learning Platform

A modern, responsive online learning platform built with ASP.NET Core MVC, featuring a beautiful dark theme with purple-teal-orange color scheme.

##  Features

- **Modern UI/UX**: Dark theme with user-friendly color scheme
- **Course Management**: Browse and enroll in various technology courses
- **User Dashboard**: Track learning progress and achievements
- **Responsive Design**: Works seamlessly on desktop, tablet, and mobile
- **Indian Pricing**: All course prices displayed in Indian Rupees (₹)
- **Multiple Categories**: Web Development, Data Science, AI, Blockchain, and more

##  Technology Stack

- **Backend**: ASP.NET Core 9.0 MVC
- **Database**: SQL Server with Entity Framework Core
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap 5
- **Icons**: Font Awesome 6
- **Fonts**: Inter (Google Fonts)

##  Prerequisites

- .NET 9.0 SDK
- SQL Server (LocalDB or full version)
- Visual Studio 2022 or VS Code
- Git

## Installation & Setup

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd OnlineLearningPlatform300
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Update database connection string**
   - Open `appsettings.json`
   - Update the `DefaultConnection` string if needed

4. **Run database migrations**
   ```bash
   dotnet ef database update
   ```

5. **Run the application**
   ```bash
   dotnet run
   ```

6. **Access the application**
   - Open browser and navigate to `https://localhost:` 
7. Note
   -create a mvc using dotnet new mvc (project name) and just copy the required files form the repo to the project
## Available Courses

The platform includes 10 comprehensive courses:

1. **Complete Web Development Bootcamp** - ₹8,299
2. **Data Science & Machine Learning** - ₹10,799
3. **Digital Marketing Mastery** - ₹6,599
4. **Mobile App Development with Flutter** - ₹9,499
5. **Cloud Computing with AWS** - ₹12,999
6. **UI/UX Design Fundamentals** - ₹7,299
7. **Cybersecurity Essentials** - ₹11,499
8. **Blockchain Development** - ₹13,799
9. **Artificial Intelligence with Python** - ₹14,999
10. **DevOps and CI/CD Pipeline** - ₹10,299

## Color Scheme

- **Primary**: Purple (#7c3aed)
- **Secondary**: Teal (#06b6d4)
- **Accent**: Orange (#f59e0b)
- **Background**: Dark Navy (#0f0f23)
- **Cards**: Dark Blue (#1a1a2e)
- **Text**: Light Gray (#f1f5f9)

## Pages & Features

### Public Pages
- **Home**: Hero section, featured courses, statistics
- **Courses**: Course catalog with search and filtering
- **Course Details**: Detailed course information and enrollment
- **About**: Company information
- **Contact**: Contact form and information

### Authentication
- **Login**: User authentication
- **Register**: New user registration

### Dashboard (User Area)
- **Dashboard**: Overview of learning progress
- **My Courses**: Enrolled courses and progress
- **Profile**: User profile management

## Project Structure

```
OnlineLearningPlatform300/
├── Controllers/          # MVC Controllers
├── Models/              # Data models
├── Views/               # Razor views
├── Data/                # Database context
├── Migrations/          # EF Core migrations
├── wwwroot/            # Static files
│   ├── css/            # Stylesheets
│   ├── js/             # JavaScript files
│   └── lib/            # Third-party libraries
└── Properties/         # Launch settings
```

##  Database Schema

### Core Models
- **User**: User information and authentication
- **Course**: Course details and metadata
- **Lesson**: Individual lessons within courses
- **Quiz**: Assessments and quizzes
- **Enrollment**: User course enrollments
- **UserProgress**: Learning progress tracking

##  Key Features Implemented

### User Experience
- Responsive design for all screen sizes
- Modern dark theme with excellent contrast
- Intuitive navigation and user interface
- Fast loading times and smooth animations

### Course Management
- Comprehensive course catalog
- Detailed course information pages
- Progress tracking and certificates
- Interactive lessons and quizzes

### Dashboard Features
- Learning statistics and progress
- Course recommendations
- Achievement tracking
- Profile management

##  Deployment

### Local Development
```bash
dotnet run --environment Development
```

### Production Build
```bash
dotnet publish -c Release -o ./publish
```



##  License

This project is licensed under the MIT License - see the LICENSE file for details.

## Developer

**Parth** - Full Stack Developer

##  Support

For support and questions:
- Email: support@eduverse.com
- Phone: 8849811782

**EduVerse** - Empowering minds through innovative online learning experiences.
