using Microsoft.AspNetCore.Mvc;

namespace HumPsiProject.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}