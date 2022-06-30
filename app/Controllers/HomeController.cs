using Microsoft.AspNetCore.Mvc;
using P4GSite.Services.Interfaces;

namespace P4GSite.Controllers;

[Route("/")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("/Views/Index.cshtml");
    }
}