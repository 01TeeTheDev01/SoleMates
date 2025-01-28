using SoleMatesWA.Models;

namespace SoleMatesWA.Repository;

public interface ICommentRepository
{
    Task<IEnumerable<CommentModel>> GetAllCommentsAsync();
    Task<IEnumerable<CommentModel>> GetCommentsAsync(Guid eventId);
    Task<CommentModel?> GetCommentAsync(Guid eventId, Guid commentId);
    Task<CommentModel?> AddCommentAsync(Guid eventId, CommentModel commentModel);
    Task<CommentModel> UpdateCommentAsync(Guid eventId, CommentModel commentModel);
    Task DeleteCommentAsync(Guid eventId, Guid commentId);
}