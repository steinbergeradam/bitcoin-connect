using BitcoinConnect.Models;

namespace BitcoinConnect.Repositories.Interfaces;

public interface IUserRepository
{
    IEnumerable<User> Get();
    User Get(Guid id);
    void Put(User user);
    void Post(User user);
    void Delete(Guid id);
}
