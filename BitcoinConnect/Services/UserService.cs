using BitcoinConnect.Models;
using BitcoinConnect.Repositories.Interfaces;
using BitcoinConnect.Services.Interfaces;

namespace BitcoinConnect.Services;

public class UserService : IUserService
{
    private IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<User> Get()
    {
        return _repository.Get();
    }

    public User Get(Guid id)
    {
        return _repository.Get(id);
    }

    public void Put(User user)
    {
        _repository.Put(user);
    }

    public void Post(User user)
    {
        _repository.Post(user);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }
}
