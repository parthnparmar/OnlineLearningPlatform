using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform300.Data;
using OnlineLearningPlatform300.Models;

namespace OnlineLearningPlatform300.Controllers;

public class LessonsController : Controller
{
    private readonly ApplicationDbContext _context;

    public LessonsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int courseId)
    {
        var course = await _context.Courses
            .Include(c => c.Lessons.OrderBy(l => l.Order))
            .FirstOrDefaultAsync(c => c.Id == courseId);

        if (course == null) return NotFound();

        ViewBag.Course = course;
        return View(course.Lessons);
    }

    public async Task<IActionResult> Details(int id)
    {
        var lesson = await _context.Lessons
            .Include(l => l.Course)
            .Include(l => l.Quizzes)
                .ThenInclude(q => q.Questions)
                    .ThenInclude(q => q.Answers)
            .FirstOrDefaultAsync(l => l.Id == id);

        if (lesson == null) return NotFound();

        return View(lesson);
    }

    [HttpPost]
    public async Task<IActionResult> MarkComplete(int lessonId, int userId = 1)
    {
        var progress = await _context.UserProgresses
            .FirstOrDefaultAsync(p => p.LessonId == lessonId && p.UserId == userId);

        if (progress == null)
        {
            progress = new UserProgress
            {
                LessonId = lessonId,
                UserId = userId,
                IsCompleted = true,
                CompletedAt = DateTime.Now
            };
            _context.UserProgresses.Add(progress);
        }
        else
        {
            progress.IsCompleted = true;
            progress.CompletedAt = DateTime.Now;
        }

        await _context.SaveChangesAsync();
        return Json(new { success = true });
    }
}