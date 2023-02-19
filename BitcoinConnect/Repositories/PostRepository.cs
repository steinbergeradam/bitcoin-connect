using BitcoinConnect.Contexts;
using BitcoinConnect.Models;
using BitcoinConnect.Repositories.Interfaces;

namespace BitcoinConnect.Repositories;

public class PostRepository : IPostRepository
{
    private readonly BitcoinConnectContext _context;

    public PostRepository(BitcoinConnectContext context)
    {
        _context = context;
    }

    public IEnumerable<Post> Get()
    {
        return _context.Posts.Where(x => !x.DeletedDate.HasValue);
    }

    public Post Get(Guid id)
    {
        return _context.Posts.Single(x => x.PostId == id && !x.DeletedDate.HasValue);
    }

    public IEnumerable<Post> GetByUserId(Guid userId)
    {
        return _context.Posts.Where(x => x.CreatedBy == userId && !x.DeletedDate.HasValue);
    }

    public void Put(Post post)
    {
        post.CreatedBy = Guid.NewGuid();
        post.CreatedDate = DateTime.Now;
        _context.Posts.Add(post);
    }

    public void Post(Post post)
    {
        post.ModifiedBy = Guid.NewGuid();
        post.ModifiedDate = DateTime.Now;
        _context.Posts.Update(post);
    }

    public void Delete(Guid id)
    {
        var post = _context.Posts.Single(x => x.PostId == id && !x.DeletedDate.HasValue);
        post.DeletedBy = Guid.NewGuid();
        post.DeletedDate = DateTime.Now;
        _context.Posts.Update(post);
    }
}
