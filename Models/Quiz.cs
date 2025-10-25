using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform300.Models;

public class Quiz
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int PassingScore { get; set; } = 70;
    
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; } = null!;
    
    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public ICollection<QuizAttempt> Attempts { get; set; } = new List<QuizAttempt>();
}

public class Question
{
    public int Id { get; set; }
    [Required]
    public string Text { get; set; } = string.Empty;
    public QuestionType Type { get; set; }
    public int Points { get; set; } = 1;
    
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; } = null!;
    
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}

public class Answer
{
    public int Id { get; set; }
    [Required]
    public string Text { get; set; } = string.Empty;
    public bool IsCorrect { get; set; }
    
    public int QuestionId { get; set; }
    public Question Question { get; set; } = null!;
}

public class QuizAttempt
{
    public int Id { get; set; }
    public int Score { get; set; }
    public bool Passed { get; set; }
    public DateTime CompletedAt { get; set; } = DateTime.Now;
    
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; } = null!;
    
    public int UserId { get; set; }
    public User User { get; set; } = null!;
}

public enum QuestionType
{
    MultipleChoice,
    TrueFalse,
    ShortAnswer
}