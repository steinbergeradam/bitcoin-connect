using BitcoinConnect.Models;
using BitcoinConnect.Repositories.Interfaces;
using BitcoinConnect.Services.Interfaces;

namespace BitcoinConnect.Services;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _repository;

    public CommentService(ICommentRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Comment> Get()
    {
        return _repository.Get();
    }

    public Comment Get(Guid id)
    {
        return _repository.Get(id);
    }

    public IEnumerable<Comment> GetByPostId(Guid userId)
    {
        return _repository.GetByPostId(userId);
    }

    public void Put(Comment comment)
    {
        _repository.Put(comment);
    }

    public void Post(Comment comment)
    {
        _repository.Post(comment);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }
}
