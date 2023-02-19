using BitcoinConnect.Contexts;
using BitcoinConnect.Models;
using BitcoinConnect.Repositories.Interfaces;

namespace BitcoinConnect.Repositories;

public class UserRepository : IUserRepository
{
    private readonly BitcoinConnectContext _context;

    public UserRepository(BitcoinConnectContext context)
    {
        _context = context;
    }

    public IEnumerable<User> Get()
    {
        return _context.Users.Where(x => !x.DeletedDate.HasValue);
    }

    public User Get(Guid id)
    {
        return _context.Users.Single(x => x.UserId == id && !x.DeletedDate.HasValue);
    }

    public void Put(User user)
    {
        user.CreatedBy = Guid.NewGuid();
        user.CreatedDate = DateTime.Now;
        _context.Users.Add(user);
    }

    public void Post(User user)
    {
        user.ModifiedBy = Guid.NewGuid();
        user.ModifiedDate = DateTime.Now;
        _context.Users.Update(user);
    }

    public void Delete(Guid id)
    {
        var user = _context.Users.Single(x => x.UserId == id && !x.DeletedDate.HasValue);
        user.DeletedBy = Guid.NewGuid();
        user.DeletedDate = DateTime.Now;
        _context.Users.Update(user);
    }
}
