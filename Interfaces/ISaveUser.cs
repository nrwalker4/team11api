using team11api.Models;

namespace team11api.Interfaces
{
    public interface ISaveUser
    {
        public void CreateUser(User myUser);
        public void SaveUser(User myUser);
    }
}