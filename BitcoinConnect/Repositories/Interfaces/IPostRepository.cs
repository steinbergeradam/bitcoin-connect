using BitcoinConnect.Models;

namespace BitcoinConnect.Repositories.Interfaces;

public interface IPostRepository
{
    IEnumerable<Post> Get();
    Post Get(Guid id);
    IEnumerable<Post> GetByUserId(Guid userId);
    void Put(Post post);
    void Post(Post post);
    void Delete(Guid id);
}
