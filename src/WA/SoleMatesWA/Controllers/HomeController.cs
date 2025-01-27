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

    [Route("gallery")]
    public IActionResult Gallery()
    {
        if (HttpContext.Request.Path.HasValue &&
            !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
            HttpContext.Request.Path.Value.Equals("/gallery"))
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

            var images = Directory.GetFiles(path)
                .Select(file => Path.GetFileName(file))
                .ToArray();

            ViewData["Images"] = images;

            HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
            HttpContext.Response.StatusCode = StatusCodes.Status200OK;
            return View();
        }
        else
        {
            HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            return BadRequest();
        }
    }

    [Route("events")]
    public IActionResult Events()
    {
        if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/events"))
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "videos");

            var videos = Directory.GetFiles(path)
                .Select(file => Path.GetFileName(file))
                .ToArray();

            ViewData["Videos"] = videos;

            HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
            HttpContext.Response.StatusCode = StatusCodes.Status200OK;
            return View();
        }
        else
        {
            HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            return BadRequest();
        }
    }

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
