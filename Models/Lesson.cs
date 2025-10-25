using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform300.Models;

public class Lesson
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public LessonType Type { get; set; }
    public string VideoUrl { get; set; } = string.Empty;
    public int Order { get; set; }
    public int Duration { get; set; }
    
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    
    public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
    public ICollection<UserProgress> UserProgresses { get; set; } = new List<UserProgress>();
}

public enum LessonType
{
    Text,
    Video,
    Quiz
}