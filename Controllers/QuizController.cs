using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform300.Data;
using OnlineLearningPlatform300.Models;

namespace OnlineLearningPlatform300.Controllers;

public class QuizController : Controller
{
    private readonly ApplicationDbContext _context;

    public QuizController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Take(int id)
    {
        var quiz = await _context.Quizzes
            .Include(q => q.Questions)
                .ThenInclude(q => q.Answers)
            .Include(q => q.Lesson)
            .FirstOrDefaultAsync(q => q.Id == id);

        if (quiz == null) return NotFound();

        return View(quiz);
    }

    [HttpPost]
    public async Task<IActionResult> Submit(int quizId, Dictionary<int, int> answers, int userId = 1)
    {
        var quiz = await _context.Quizzes
            .Include(q => q.Questions)
                .ThenInclude(q => q.Answers)
            .FirstOrDefaultAsync(q => q.Id == quizId);

        if (quiz == null) return NotFound();

        int totalPoints = 0;
        int earnedPoints = 0;

        foreach (var question in quiz.Questions)
        {
            totalPoints += question.Points;
            if (answers.ContainsKey(question.Id))
            {
                var selectedAnswer = question.Answers.FirstOrDefault(a => a.Id == answers[question.Id]);
                if (selectedAnswer?.IsCorrect == true)
                {
                    earnedPoints += question.Points;
                }
            }
        }

        int score = totalPoints > 0 ? (earnedPoints * 100) / totalPoints : 0;
        bool passed = score >= quiz.PassingScore;

        var attempt = new QuizAttempt
        {
            QuizId = quizId,
            UserId = userId,
            Score = score,
            Passed = passed,
            CompletedAt = DateTime.Now
        };

        _context.QuizAttempts.Add(attempt);
        await _context.SaveChangesAsync();

        return View("Result", new { Quiz = quiz, Score = score, Passed = passed, Attempt = attempt });
    }

    public async Task<IActionResult> Results(int attemptId)
    {
        var attempt = await _context.QuizAttempts
            .Include(a => a.Quiz)
                .ThenInclude(q => q.Questions)
                    .ThenInclude(q => q.Answers)
            .FirstOrDefaultAsync(a => a.Id == attemptId);

        if (attempt == null) return NotFound();

        return View(attempt);
    }
}