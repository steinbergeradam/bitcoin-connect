using BitcoinConnect.Contexts;
using BitcoinConnect.Models;
using BitcoinConnect.Repositories.Interfaces;

namespace BitcoinConnect.Repositories;

public class CommentRepository : ICommentRepository
{
    private readonly BitcoinConnectContext _context;

    public CommentRepository(BitcoinConnectContext context)
    {
        _context = context;
    }

    public IEnumerable<Comment> Get()
    {
        return _context.Comments.Where(x => !x.DeletedDate.HasValue);
    }

    public Comment Get(Guid id)
    {
        return _context.Comments.Single(x => x.CommentId == id && !x.DeletedDate.HasValue);
    }

    public IEnumerable<Comment> GetByPostId(Guid postId)
    {
        return _context.Comments.Where(x => x.PostId == postId && !x.DeletedDate.HasValue);
    }

    public void Put(Comment comment)
    {
        comment.CreatedBy = Guid.NewGuid();
        comment.CreatedDate = DateTime.Now;
        _context.Comments.Add(comment);
    }

    public void Post(Comment comment)
    {
        comment.ModifiedBy = Guid.NewGuid();
        comment.ModifiedDate = DateTime.Now;
        _context.Comments.Update(comment);
    }

    public void Delete(Guid id)
    {
        var comment = _context.Comments.Single(x => x.CommentId == id && !x.DeletedDate.HasValue);
        comment.DeletedBy = Guid.NewGuid();
        comment.DeletedDate = DateTime.Now;
        _context.Comments.Update(comment);
    }
}
