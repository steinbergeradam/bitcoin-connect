using BitcoinConnect.Models;

namespace BitcoinConnect.Services.Interfaces;

public interface IUserService
{
    IEnumerable<User> Get();
    User Get(Guid id);
    void Put(User user);
    void Post(User user);
    void Delete(Guid id);
}
