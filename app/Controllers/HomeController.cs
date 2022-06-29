using Microsoft.AspNetCore.Mvc;

namespace P4GSite.Controllers;
[Route("/")]
public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View("/Views/Index.cshtml");
    }
}