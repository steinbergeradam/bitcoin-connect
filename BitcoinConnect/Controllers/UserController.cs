using BitcoinConnect.Models;
using BitcoinConnect.Services;
using BitcoinConnect.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BitcoinConnect.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ILogger<UserController> _logger;

    public UserController
    (
        IUserService userService,
        ILogger<UserController> logger
    )
    {
        _userService = userService;
        _logger = logger;
    }

    [HttpGet]
    // Used to get a list of users
    public IEnumerable<User> Get()
    {
        return _userService.Get();
    }

    [HttpGet("{id}")]
    // Used to get a single user
    public User Get(Guid id)
    {
        return _userService.Get(id);
    }

    [HttpPut]
    // Used to create a user
    public void Put(User user)
    {
        _userService.Put(user);
    }

    [HttpPost]
    // Used to update a user
    public void Post(User user)
    {
        _userService.Post(user);
    }

    [HttpDelete("{id}")]
    // Used to delete a user
    public void Delete(Guid id)
    {
        _userService.Delete(id);
    }
}