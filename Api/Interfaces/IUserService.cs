using Api.Models;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface IUserService
    {
        Task AddUser(string username, int age, string email);
        Task RemoveUser(string username);
        Task<User> GetUser(string username);
    }
}
