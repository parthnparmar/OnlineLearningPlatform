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
OUTPUT:
<img width="1911" height="1079" alt="Screenshot 2025-10-25 212320" src="https://github.com/user-attachments/assets/2626f113-cd91-4998-9157-439d6d4dde6a" />
<img width="1919" height="1079" alt="Screenshot 2025-10-25 212342" src="https://github.com/user-attachments/assets/527e85f9-e790-4f76-9173-39cc7aae7a7e" />
<img width="1910" height="1078" alt="Screenshot 2025-10-25 212423" src="https://github.com/user-attachments/assets/416897c0-70ca-4630-8eb7-45800ce05627" />
<img width="1919" height="1077" alt="Screenshot 2025-10-25 212543" src="https://github.com/user-attachments/assets/97883979-d94f-43b3-91b7-61f79e164e8d" />
<img width="1919" height="1079" alt="Screenshot 2025-10-25 212600" src="https://github.com/user-attachments/assets/9222a17d-1e11-4dc1-b578-4f5e7cf916cb" />
<img width="916" height="1015" alt="Screenshot 2025-10-25 212634" src="https://github.com/user-attachments/assets/b72b1719-1fed-4e03-b3c5-8e1510f2f8a9" />
<img width="34" height="19" alt="Screenshot 2025-10-25 212701" src="https://github.com/user-attachments/assets/16ab4952-b67e-4c51-94dc-a9ce3987578d" />
<img width="1919" height="1079" alt="Screenshot 2025-10-25 212718" src="https://github.com/user-attachments/assets/6dac97bf-ccdd-46fd-81bf-98687694c608" />
<img width="1916" height="1079" alt="Screenshot 2025-10-25 212750" src="https://github.com/user-attachments/assets/34197ce8-bb46-47cd-8b47-2f530b117a99" />
<img width="1919" height="1079" alt="Screenshot 2025-10-25 212917" src="https://github.com/user-attachments/assets/c3299dc7-95e4-4557-9bde-46d0b2dbeb6c" />
<img width="1909" height="1079" alt="Screenshot 2025-10-25 212959" src="https://github.com/user-attachments/assets/466060fe-3ec6-49f8-a106-b9cadd342d6a" />
<img width="1915" height="1079" alt="Screenshot 2025-10-25 213120" src="https://github.com/user-attachments/assets/e9dd1a30-4ae6-404a-92c0-b617e6f669e6" />
<img width="1919" height="1079" alt="Screenshot 2025-10-25 213139" src="https://github.com/user-attachments/assets/a7821ce6-767e-483e-889f-914d0c8c397c" />
<img width="1919" height="1079" alt="Screenshot 2025-10-25 213206" src="https://github.com/user-attachments/assets/6d0f2577-5821-488e-899d-0980877668c7" />
<img width="1918" height="1079" alt="Screenshot 2025-10-25 214031" src="https://github.com/user-attachments/assets/ae84d59e-b24a-4583-b3b2-73a0d9b6ebde" />









