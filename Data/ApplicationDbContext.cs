using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform300.Models;

namespace OnlineLearningPlatform300.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<UserProgress> UserProgresses { get; set; }
    public DbSet<QuizAttempt> QuizAttempts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>()
            .Property(c => c.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Course>().HasData(
            new Course { Id = 1, Title = "Complete Web Development Bootcamp", Description = "Master HTML, CSS, JavaScript, React, Node.js, and MongoDB", ImageUrl = "https://images.unsplash.com/photo-1516321318423-f06f85e504b3", Price = 8299, Category = "Web Development", Level = "Beginner", Duration = 40 },
            new Course { Id = 2, Title = "Data Science & Machine Learning", Description = "Learn Python, pandas, scikit-learn, and TensorFlow", ImageUrl = "https://images.unsplash.com/photo-1551288049-bebda4e38f71", Price = 10799, Category = "Data Science", Level = "Intermediate", Duration = 35 },
            new Course { Id = 3, Title = "Digital Marketing Mastery", Description = "Complete guide to SEO, social media marketing, and Google Ads", ImageUrl = "https://images.unsplash.com/photo-1460925895917-afdab827c52f", Price = 6599, Category = "Marketing", Level = "Beginner", Duration = 25 },
            new Course { Id = 4, Title = "Mobile App Development with Flutter", Description = "Build cross-platform mobile apps using Flutter and Dart", ImageUrl = "https://images.unsplash.com/photo-1512941937669-90a1b58e7e9c", Price = 9499, Category = "Mobile Development", Level = "Intermediate", Duration = 45 },
            new Course { Id = 5, Title = "Cloud Computing with AWS", Description = "Master Amazon Web Services and cloud architecture", ImageUrl = "https://images.unsplash.com/photo-1451187580459-43490279c0fa", Price = 12999, Category = "Cloud Computing", Level = "Advanced", Duration = 50 },
            new Course { Id = 6, Title = "UI/UX Design Fundamentals", Description = "Learn design principles, Figma, and user experience design", ImageUrl = "https://images.unsplash.com/photo-1581291518857-4e27b48ff24e", Price = 7299, Category = "Design", Level = "Beginner", Duration = 30 },
            new Course { Id = 7, Title = "Cybersecurity Essentials", Description = "Protect systems and networks from digital attacks", ImageUrl = "https://images.unsplash.com/photo-1550751827-4bd374c3f58b", Price = 11499, Category = "Cybersecurity", Level = "Intermediate", Duration = 38 },
            new Course { Id = 8, Title = "Blockchain Development", Description = "Build decentralized applications with Ethereum and Solidity", ImageUrl = "https://images.unsplash.com/photo-1639762681485-074b7f938ba0", Price = 13799, Category = "Blockchain", Level = "Advanced", Duration = 42 },
            new Course { Id = 9, Title = "Artificial Intelligence with Python", Description = "Deep learning, neural networks, and AI applications", ImageUrl = "https://images.unsplash.com/photo-1677442136019-21780ecad995", Price = 14999, Category = "Artificial Intelligence", Level = "Advanced", Duration = 55 },
            new Course { Id = 10, Title = "DevOps and CI/CD Pipeline", Description = "Automate deployment with Docker, Kubernetes, and Jenkins", ImageUrl = "https://images.unsplash.com/photo-1618401471353-b98afee0b2eb", Price = 10299, Category = "DevOps", Level = "Intermediate", Duration = 40 }
        );

        modelBuilder.Entity<Lesson>().HasData(
            new Lesson { Id = 1, Title = "Introduction to HTML", Content = "Learn the basics of HTML structure and elements", Type = LessonType.Video, VideoUrl = "https://example.com/video1", Order = 1, Duration = 15, CourseId = 1 },
            new Lesson { Id = 2, Title = "CSS Fundamentals", Content = "Understanding CSS selectors, properties, and styling", Type = LessonType.Video, VideoUrl = "https://example.com/video2", Order = 2, Duration = 20, CourseId = 1 },
            new Lesson { Id = 3, Title = "HTML & CSS Quiz", Content = "Test your knowledge of HTML and CSS", Type = LessonType.Quiz, Order = 3, Duration = 10, CourseId = 1 }
        );

        modelBuilder.Entity<Quiz>().HasData(
            new Quiz { Id = 1, Title = "HTML & CSS Assessment", Description = "Test your understanding of HTML and CSS basics", PassingScore = 70, LessonId = 3 }
        );

        modelBuilder.Entity<Question>().HasData(
            new Question { Id = 1, Text = "What does HTML stand for?", Type = QuestionType.MultipleChoice, Points = 10, QuizId = 1 },
            new Question { Id = 2, Text = "CSS is used for styling web pages.", Type = QuestionType.TrueFalse, Points = 10, QuizId = 1 }
        );

        modelBuilder.Entity<Answer>().HasData(
            new Answer { Id = 1, Text = "HyperText Markup Language", IsCorrect = true, QuestionId = 1 },
            new Answer { Id = 2, Text = "High Tech Modern Language", IsCorrect = false, QuestionId = 1 },
            new Answer { Id = 3, Text = "Home Tool Markup Language", IsCorrect = false, QuestionId = 1 },
            new Answer { Id = 4, Text = "True", IsCorrect = true, QuestionId = 2 },
            new Answer { Id = 5, Text = "False", IsCorrect = false, QuestionId = 2 }
        );
    }
}