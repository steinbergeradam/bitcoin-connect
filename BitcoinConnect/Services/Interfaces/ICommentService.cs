using BitcoinConnect.Models;

namespace BitcoinConnect.Services.Interfaces;

public interface ICommentService
{
    IEnumerable<Comment> Get();
    Comment Get(Guid id);
    IEnumerable<Comment> GetByPostId(Guid userId);
    void Put(Comment comment);
    void Post(Comment comment);
    void Delete(Guid id);
}
