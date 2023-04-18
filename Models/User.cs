using team11api.Interfaces;
using team11api.Databases;

namespace team11api.Models
{
    public class User
    {
        public string Username{get;set;}
        public string UserPassword{get;set;}
        public string Email{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public bool IsAdmin{get;set;}
        public bool Deleted{get;set;}
        public ISaveUser Save{get;set;}
        public User(){
            Save = new SaveUser();
        }
    }
}