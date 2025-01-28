using Microsoft.EntityFrameworkCore;

using SoleMatesWA.Data;
using SoleMatesWA.Models;

namespace SoleMatesWA.Repository;

public class CommentRepository : ICommentRepository
{
    private readonly SoleMatesWAContext _context;
    private readonly ILogger<CommentRepository> _logger;

    public CommentRepository(SoleMatesWAContext context, ILogger<CommentRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// Retrieves all comments for a specific event.
    /// </summary>
    /// <param name="eventId">The ID of the event.</param>
    /// <returns>A list of comments for the specified event.</returns>
    public async Task<IEnumerable<CommentModel>> GetCommentsAsync(Guid eventId)
    {
        try
        {
            return await _context.Comments
                .Where(c => c.EventId == eventId)
                .AsNoTracking()
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting comments for event with ID {EventId}.", eventId);
            return new List<CommentModel>();
        }
    }

    /// <summary>
    /// Retrieves a specific comment for a specific event.
    /// </summary>
    /// <param name="eventId">The ID of the event.</param>
    /// <param name="commentId">The ID of the comment.</param>
    /// <returns>The comment if found, otherwise null.</returns>
    public async Task<CommentModel?> GetCommentAsync(Guid eventId, Guid commentId)
    {
        try
        {
            return await _context.Comments
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.EventId == eventId && c.Id == commentId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting the comment with ID {CommentId} for event with ID {EventId}.", commentId, eventId);
            return null;
        }
    }

    /// <summary>
    /// Adds a new comment to a specific event.
    /// </summary>
    /// <param name="eventId">The ID of the event.</param>
    /// <param name="commentModel">The comment model to add.</param>
    /// <returns>The added comment model if successful, otherwise null.</returns>
    public async Task<CommentModel?> AddCommentAsync(Guid eventId, CommentModel commentModel)
    {
        try
        {
            commentModel.EventId = eventId;
            _context.Comments.Add(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while adding a new comment for event with ID {EventId}.", eventId);
            return null;
        }
    }

    /// <summary>
    /// Updates an existing comment for a specific event.
    /// </summary>
    /// <param name="eventId">The ID of the event.</param>
    /// <param name="commentModel">The comment model to update.</param>
    /// <returns>The updated comment model.</returns>
    public async Task<CommentModel> UpdateCommentAsync(Guid eventId, CommentModel commentModel)
    {
        try
        {
            commentModel.EventId = eventId;
            _context.Entry(commentModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return commentModel;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while updating the comment with ID {CommentId} for event with ID {EventId}.", commentModel.Id, eventId);
            throw;
        }
    }

    /// <summary>
    /// Deletes a specific comment for a specific event.
    /// </summary>
    /// <param name="eventId">The ID of the event.</param>
    /// <param name="commentId">The ID of the comment.</param>
    public async Task DeleteCommentAsync(Guid eventId, Guid commentId)
    {
        try
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.EventId == eventId && c.Id == commentId);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
                await _context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while deleting the comment with ID {CommentId} for event with ID {EventId}.", commentId, eventId);
        }
    }

    /// <summary>
    /// Retrieves all comments.
    /// </summary>
    /// <returns>A list of all comments.</returns>
    public async Task<IEnumerable<CommentModel>> GetAllCommentsAsync()
    {
        try
        {
            return await _context
                .Comments
                .Include(c => c.Event)
                .AsNoTracking()
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting all comments.");
            return new List<CommentModel>();
        }
    }
}
