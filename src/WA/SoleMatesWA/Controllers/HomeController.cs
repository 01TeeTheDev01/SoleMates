using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using SoleMatesWA.Models;
using SoleMatesWA.Repository;
using SoleMatesWA.Services;
using SoleMatesWA.Utils;

namespace SoleMatesWA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEventService _eventService;
    private readonly ICommentService _commentSerivce;
    private readonly IMediaService _mediaHelper;

    public HomeController(ILogger<HomeController> logger, IEventService eventRepository, ICommentService commentRepository, IMediaService mediaHelper)
    {
        _logger = logger;
        _eventService = eventRepository;
        _commentSerivce = commentRepository;
        _mediaHelper = mediaHelper;
    }

    [Route("/")]
    public async Task<IActionResult> Index()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/") &&
                HttpContext.Request.Method.Equals(HttpMethod.Get.Method))
            {
                ViewData["CarouselImages"] = await _mediaHelper.LoadCarouselMediaAsync();
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return View();
            }
            else
            {
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return BadRequest(StaticUtils.BAD_REQUEST_MESSAGE(HttpContext.Request.Path.Value ?? "Invalid Method"));
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
    public async Task<IActionResult> AboutAsync()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/about") &&
                HttpContext.Request.Method.Equals(HttpMethod.Get.Method))
            {
                ViewData["CarouselImages"] = await _mediaHelper.LoadCarouselMediaAsync();
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return View();
            }
            else
            {
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return BadRequest(StaticUtils.BAD_REQUEST_MESSAGE(HttpContext.Request.Path.Value ?? "Invalid Method"));
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
    public async Task<IActionResult> GalleryAsync()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/gallery") &&
                HttpContext.Request.Method.Equals(HttpMethod.Get.Method))
            {
                ViewData["CarouselImages"] = await _mediaHelper.LoadCarouselMediaAsync();
                ViewData["GalleryImages"] = await _mediaHelper.LoadGalleryMediaAsync();
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return View();
            }
            else
            {
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return BadRequest(StaticUtils.BAD_REQUEST_MESSAGE(HttpContext.Request.Path.Value ?? "Invalid Method"));
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
                HttpContext.Request.Path.Value.Equals("/events") &&
                HttpContext.Request.Method.Equals(HttpMethod.Get.Method))
            {
                string[] videos = await _mediaHelper.LoadEventMediaAsync();
                ViewData["CarouselImages"] = await _mediaHelper.LoadCarouselMediaAsync();
                var events = await _eventService.GetEventsAsync();
                var comments = await _commentSerivce.GetAllCommentsAsync();

                if (videos.Length > 0 && events.Any())
                    ViewData["EventsMedia"] = videos;

                if (events.Any())
                    ViewData["Events"] = events
                        .Where(ev => ev.Date.Year == DateTime.Now.Year && ev.Date >= DateOnly.FromDateTime(DateTime.Now))
                        .OrderBy(ev => ev.Date);

                if (comments.Any())
                    ViewData["Comments"] = comments.OrderByDescending(c => c.Date).ThenByDescending(c => c.Time);

                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return View();
            }

            HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            return BadRequest(StaticUtils.BAD_REQUEST_MESSAGE(HttpContext.Request.Path.Value ?? "Invalid Method"));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while processing the events request.");
            HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
        }
    }

    [Route("terms-of-service")]
    public async Task<IActionResult> TermsOfServiceAsync()
    {
        try
        {
            if (HttpContext.Request.Path.HasValue &&
                !string.IsNullOrEmpty(HttpContext.Request.Path.Value) &&
                HttpContext.Request.Path.Value.Equals("/terms-of-service") &&
                HttpContext.Request.Method.Equals(HttpMethod.Get.Method))
            {
                ViewData["CarouselImages"] = await _mediaHelper.LoadCarouselMediaAsync();
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return View();
            }
            else
            {
                HttpContext.Response.Headers.Append("Path", HttpContext.Request.Path.Value);
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return BadRequest(StaticUtils.BAD_REQUEST_MESSAGE(HttpContext.Request.Path.Value ?? "Invalid Method"));
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while processing the gallery request.");
            HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
}