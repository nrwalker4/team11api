using team11api.Models;

namespace team11api.Interfaces
{
    public interface ISaveUser
    {
        void CreateUser(User myUser);
        void SaveUser(User myUser);
    }
}