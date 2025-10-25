using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform300.Data;
using OnlineLearningPlatform300.Models;

namespace OnlineLearningPlatform300.Controllers;

public class CoursesController : Controller
{
    private readonly ApplicationDbContext _context;

    public CoursesController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var courses = await _context.Courses.ToListAsync();
        return View(courses);
    }

    public async Task<IActionResult> Details(int id)
    {
        var course = await _context.Courses
            .Include(c => c.Lessons.OrderBy(l => l.Order))
            .FirstOrDefaultAsync(c => c.Id == id);

        if (course == null) return NotFound();

        ViewBag.CourseId = id;
        return View(course);
    }

    public IActionResult Enroll(int id)
    {
        ViewBag.CourseId = id;
        return View();
    }
}