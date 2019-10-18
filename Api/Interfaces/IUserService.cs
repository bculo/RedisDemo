using Api.Models;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface IUserService
    {
        Task AddUser(User user);
        Task RemoveUser(string username);
        Task<User> GetUser(string username);
    }
}
