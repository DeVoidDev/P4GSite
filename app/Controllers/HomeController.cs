using Microsoft.AspNetCore.Mvc;

namespace P4GSite.Controllers;

[Route("/")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("/Views/Index.cshtml");
    }
}