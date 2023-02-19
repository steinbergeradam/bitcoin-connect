using BitcoinConnect.Models;
using BitcoinConnect.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BitcoinConnect.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
    private readonly ICommentService _commentService;
    private readonly ILogger<CommentController> _logger;

    public CommentController
    (
        ICommentService commentService,
        ILogger<CommentController> logger
    )
    {
        _commentService = commentService;
        _logger = logger;
    }

    [HttpGet]
    // Used to get a list of comments
    public IEnumerable<Comment> Get()
    {
        return _commentService.Get();
    }

    [HttpGet("{id}")]
    // Used to get a single comment
    public Comment Get(Guid id)
    {
        return _commentService.Get(id);
    }

    [HttpGet("ByPostId/{postId}")]
    // Used to get a single comment
    public IEnumerable<Comment> GetByPostId(Guid postId)
    {
        return _commentService.GetByPostId(postId);
    }

    [HttpPut]
    // Used to create a comment
    public void Put(Comment comment)
    {
        _commentService.Put(comment);
    }

    [HttpPost]
    // Used to update a comment
    public void Post(Comment comment)
    {
        _commentService.Post(comment);
    }

    [HttpDelete("{id}")]
    // Used to delete a comment
    public void Delete(Guid id)
    {
        _commentService.Delete(id);
    }
}
