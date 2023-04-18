using team11api.Models;

namespace team11api.Interfaces
{
    public interface IReadAllUsers
    {
         public List<User> GetAllUsers();
    }
}