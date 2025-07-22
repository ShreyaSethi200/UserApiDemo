using UserApiDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace UserApiDemo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<User> users = new List<User>
        {
            new User { UserId = 1, FirstName = "Alice", LastName = "Smith", Email = "alice@example.com" },
            new User { UserId = 2, FirstName = "Bob", LastName = "Jones", Email = "bob@example.com" }
        };

        public User GetUserById(int userId)
        {
            return users.FirstOrDefault(u => u.UserId == userId);
        }

        public User AddUser(User user)
        {
            int newId = users.Any() ? users.Max(u => u.UserId) + 1 : 1;
            user.UserId = newId;
            users.Add(user);
            return user;
        }
    }
}
