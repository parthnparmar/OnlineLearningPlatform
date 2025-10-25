using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform300.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ProfileImage { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    public ICollection<UserProgress> Progresses { get; set; } = new List<UserProgress>();
    public ICollection<QuizAttempt> QuizAttempts { get; set; } = new List<QuizAttempt>();
}

public class Enrollment
{
    public int Id { get; set; }
    public DateTime EnrolledAt { get; set; } = DateTime.Now;
    public bool IsCompleted { get; set; }
    public int Progress { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
}

public class UserProgress
{
    public int Id { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CompletedAt { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;
}