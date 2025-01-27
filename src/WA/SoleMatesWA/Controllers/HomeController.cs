using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using SoleMatesWA.Models;

namespace SoleMatesWA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("about")]
    public IActionResult About() => View();

    [Route("/")]
    public IActionResult Index() => View();

    [Route("privacy")]
    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
