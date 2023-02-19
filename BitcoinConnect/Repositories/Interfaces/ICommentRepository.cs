using BitcoinConnect.Models;

namespace BitcoinConnect.Repositories.Interfaces;

public interface ICommentRepository
{
    IEnumerable<Comment> Get();
    Comment Get(Guid id);
    IEnumerable<Comment> GetByPostId(Guid userId);
    void Put(Comment comment);
    void Post(Comment comment);
    void Delete(Guid id);
}
