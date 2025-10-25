using Microsoft.AspNetCore.Mvc;

namespace OnlineLearningPlatform300.Controllers;

public class AuthController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        // Demo login - redirect to dashboard
        return RedirectToAction("Index", "Dashboard");
    }

    [HttpPost]
    public IActionResult Register(string name, string email, string password)
    {
        // Demo registration - redirect to dashboard
        return RedirectToAction("Index", "Dashboard");
    }
}