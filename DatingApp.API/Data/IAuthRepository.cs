using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         // Register user, return User
         Task<User> Register(User user, string password);

        // Login user, return User
         Task<User> Login(string username, string password);

        // Check if username already exists, return true or false
         Task<bool> UserExists(string username);
    }
}