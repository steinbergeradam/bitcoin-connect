using BitcoinConnect.Models;

namespace BitcoinConnect.Services.Interfaces;

public interface IPostService
{
    IEnumerable<Post> Get();
    Post Get(Guid id);
    IEnumerable<Post> GetByUserId(Guid userId);
    void Put(Post post);
    void Post(Post post);
    void Delete(Guid id);
}
