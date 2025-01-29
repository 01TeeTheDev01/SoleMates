namespace SoleMatesWA.Services;

public interface IMediaService
{
    Task<string[]> LoadCarouselMediaAsync();
    Task<string[]> LoadGalleryMediaAsync();
    Task<string[]> LoadEventMediaAsync();
}