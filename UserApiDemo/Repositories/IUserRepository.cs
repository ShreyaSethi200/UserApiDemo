using UserApiDemo.Models;

namespace UserApiDemo.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int userId);
        User AddUser(User user);
    }
}
