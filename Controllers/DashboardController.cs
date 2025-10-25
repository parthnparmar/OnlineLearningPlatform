using Microsoft.AspNetCore.Mvc;

namespace OnlineLearningPlatform300.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }

    public IActionResult MyCourses()
    {
        return View();
    }
}