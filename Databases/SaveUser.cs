using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class SaveUser : ISaveUser
    {
        public void CreateUser(User myUser)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO users(username,userPassword,email,firstName,lastName,isAdmin, deleted) 
            VALUES(@username,@userPassword,@email,@firstName,@lastName,@isAdmin, @deleted)";

            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.Parameters.AddWithValue("@username",myUser.Username);
            cmd.Parameters.AddWithValue("@userPassword",myUser.UserPassword);
            cmd.Parameters.AddWithValue("@email",myUser.Email);
            cmd.Parameters.AddWithValue("@firstName",myUser.FirstName);
            cmd.Parameters.AddWithValue("@lastName",myUser.LastName);
            cmd.Parameters.AddWithValue("@isAdmin",myUser.IsAdmin);
            cmd.Parameters.AddWithValue("@deleted",myUser.Deleted);
        
            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }

        void ISaveUser.SaveUser(User myUser)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE users set userPassword=@userPassword,email=@email,firstName=@firstName,lastName=@lastName,isAdmin=@isAdmin, deleted=@deleted WHERE username = @username";

            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.CommandText=@"UPDATE users set userPassword=@userPassword,email=@email,firstName=@firstName,lastName=@lastName,isAdmin=@isAdmin, deleted=@deleted WHERE username = @username";
            cmd.Parameters.AddWithValue("@username",myUser.Username);
            cmd.Parameters.AddWithValue("@userPassword",myUser.UserPassword);
            cmd.Parameters.AddWithValue("@email",myUser.Email);
            cmd.Parameters.AddWithValue("@firstName",myUser.FirstName);
            cmd.Parameters.AddWithValue("@lastName",myUser.LastName);
            cmd.Parameters.AddWithValue("@isAdmin",myUser.IsAdmin);
            cmd.Parameters.AddWithValue("@deleted",myUser.Deleted);
        
            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}