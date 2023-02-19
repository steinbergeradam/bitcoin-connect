using BitcoinConnect.Models;
using BitcoinConnect.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BitcoinConnect.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;
    private readonly ILogger<PostController> _logger;

    public PostController
    (
        IPostService postService,
        ILogger<PostController> logger
    )
    {
        _postService = postService;
        _logger = logger;
    }

    [HttpGet]
    // Used to get a list of posts
    public IEnumerable<Post> Get()
    {
        return _postService.Get();
    }

    [HttpGet("{id}")]
    // Used to get a single post
    public Post Get(Guid id)
    {
        return _postService.Get(id);
    }

    [HttpGet("ByUserId/{userId}")]
    // Used to get a single post
    public IEnumerable<Post> GetByUserId(Guid userId)
    {
        return _postService.GetByUserId(userId);
    }

    [HttpPut]
    // Used to create a post
    public void Put(Post post)
    {
        _postService.Put(post);
    }

    [HttpPost]
    // Used to update a post
    public void Post(Post post)
    {
        _postService.Post(post);
    }

    [HttpDelete("{id}")]
    // Used to delete a post
    public void Delete(Guid id)
    {
        _postService.Delete(id);
    }
}
