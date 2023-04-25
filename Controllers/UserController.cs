using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using team11api.Models;
using team11api.Databases;
using team11api.Interfaces;


namespace team11api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public List<User> Get()
        {
            IReadAllUsers readUsers = new ReadAllUsers();
            List<User> myUsers = readUsers.GetAllUsers();
            return myUsers;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/User
        [HttpPost]
        public void Post([FromBody] User myUser)
        {
            System.Console.WriteLine("Inside the post");

            User addedUser = new User(){Username=myUser.Username,UserPassword=myUser.UserPassword,Email=myUser.Email,FirstName=myUser.FirstName,
            LastName=myUser.LastName,IsAdmin=myUser.IsAdmin,Deleted=myUser.Deleted};

            addedUser.Save.CreateUser(addedUser);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User myUser)
        {
            System.Console.WriteLine("Inside the put");

            User addedUser = new User(){Username=myUser.Username,UserPassword=myUser.UserPassword,Email=myUser.Email,FirstName=myUser.FirstName,
            LastName=myUser.LastName,IsAdmin=myUser.IsAdmin,Deleted=myUser.Deleted};

            addedUser.Save.SaveUser(addedUser);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public void Delete(string username)
        {
            System.Console.WriteLine("Inside the delete");
            IDeleteUser deleteUser = new DeleteUser();
            deleteUser.DeleteUser(username);
        }
    }
}
