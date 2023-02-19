using BitcoinConnect.Models;
using BitcoinConnect.Repositories.Interfaces;
using BitcoinConnect.Services.Interfaces;

namespace BitcoinConnect.Services;

public class PostService : IPostService
{
    private readonly IPostRepository _repository;

    public PostService(IPostRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Post> Get()
    {
        return _repository.Get();
    }

    public Post Get(Guid id)
    {
        return _repository.Get(id);
    }

    public IEnumerable<Post> GetByUserId(Guid userId)
    {
        return _repository.GetByUserId(userId);
    }

    public void Put(Post post)
    {
        _repository.Put(post);
    }

    public void Post(Post post)
    {
        _repository.Post(post);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }
}
