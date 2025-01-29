namespace SoleMatesWA.Services;

public class MediaHelper : IMediaService
{
    private readonly ILogger<MediaHelper> _logger;

    public MediaHelper(ILogger<MediaHelper> logger)
    {
        _logger = logger;
    }

    public async Task<string[]> LoadCarouselMediaAsync()
    {
        try
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

            var images = Directory.GetFiles(path).Select(file => Path.GetFileName(file)).ToArray();

            return await Task.FromResult(images);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while loading the carousel images.");
            return [];
        }
    }

    public async Task<string[]> LoadEventMediaAsync()
    {
        try
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "events", "videos");

            var videos = Directory.GetFiles(path).Select(file => Path.GetFileName(file)).ToArray();

            return await Task.FromResult(videos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while loading the event videos.");
            return [];
        }
    }

    public async Task<string[]> LoadGalleryMediaAsync()
    {
        try
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

            var images = Directory.GetFiles(path).Select(file => Path.GetFileName(file)).ToArray();

            return await Task.FromResult(images);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while loading the carousel images.");
            return [];
        }
    }
}