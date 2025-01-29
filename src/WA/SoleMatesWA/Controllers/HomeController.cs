using System.Diagnostics;
using System.Diagnostics.Tracing;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using SoleMatesWA.Models;
using SoleMatesWA.Repository;

using static System.Net.Mime.MediaTypeNames;

namespace SoleMatesWA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEventRepository _eventService;
    private readonly ICommentRepository _commentSerivce;

    public HomeController(ILogger<HomeController> logger, IEventRepository eventRepository, ICommentRepository commentRepository)
    {
        _logger = logger;
        _eventService = eventRepository;
        _commentSerivce = commentRepository;
    }

    [Route("/")]
    public IActionResult Index()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/"))
            {
                ViewData["CarouselImages"] = LoadCarouselImages();
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
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while processing the gallery request.");
            HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
        }
    }

    [Route("about")]
    public IActionResult About()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/about"))
            {
                ViewData["CarouselImages"] = LoadCarouselImages();
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
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while processing the gallery request.");
            HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
        }
    }

    [Route("gallery")]
    public IActionResult Gallery()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/gallery"))
            {
                ViewData["CarouselImages"] = LoadCarouselImages();
                ViewData["GalleryImages"] = LoadGalleryImages();
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
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while processing the gallery request.");
            HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
        }
    }

    [Route("events")]
    public async Task<IActionResult> Events()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/events"))
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "events", "videos");

                var videos = Directory.GetFiles(path).Select(file => Path.GetFileName(file)).ToArray();

                ViewData["CarouselImages"] = LoadCarouselImages();

                var events = await _eventService.GetEventsAsync();

                var comments = await _commentSerivce.GetAllCommentsAsync();

                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);

                if (videos.Length > 0 && events.Any())
                {
                    ViewData["Videos"] = videos;

                    ViewData["Events"] = events
                        .Where(ev => ev.Date.Year == DateTime.Now.Year && ev.Date >= DateOnly.FromDateTime(DateTime.Now))
                        .OrderBy(ev => ev.Date);

                    ViewData["Comments"] = comments
                        .OrderByDescending(c => c.Date)
                        .ThenByDescending(c => c.Time);

                    HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                }
                else
                {
                    HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                }

                return View();
            }

            HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            return BadRequest();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while processing the events request.");
            HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
        }
    }

    [Route("comments")]
    public async Task<IActionResult> GetComments(string eventId)
    {
        Guid id = Guid.Parse(eventId);

        var comments = await _commentSerivce.GetCommentsAsync(id);

        if (comments is not null)
        {
            return Json(comments
                .Where(c => c.EventId == id)
                .OrderByDescending(c => c.Date)
                .Select(c => new
                {
                    c.User,
                    c.Comment,
                    CommentDate = c.Date.ToString("g")
                }).ToList());
        }

        return BadRequest();
    }

    [Route("comment")]
    public async Task<IActionResult> AddComment([FromBody] CommentModel model)
    {
        if (ModelState.IsValid)
        {
            model.Id = Guid.NewGuid();
            var newCommet = await _commentSerivce.AddCommentAsync(model.Id, model);
            if (newCommet is not null)
                return Ok();
            else
                return BadRequest("Failed to add comment.");

        }

        return BadRequest("Invalid comment data.");
    }

    [Route("privacy")]
    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private static string[] LoadGalleryImages()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

        var images = Directory.GetFiles(path)
            .Select(file => Path.GetFileName(file))
            .ToArray();

        return images;
    }

    private static string[] LoadCarouselImages()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

        var images = Directory.GetFiles(path)
            .Select(file => Path.GetFileName(file))
            .ToArray();

        return images;
    }
}
