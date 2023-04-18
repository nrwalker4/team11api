using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class ReadAllUsers : IReadAllUsers
    {
        public List<User> GetAllUsers(){
           List<User> allUsers = new List<User>();

           //make and open connection
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //read command with all data
            string stm = @"SELECT * FROM users";
            using var cmd = new MySqlCommand(stm,con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read()){
                User temp = new User(){
                    Username=rdr.GetString(0),
                    UserPassword=rdr.GetString(1),
                    Email=rdr.GetString(2),
                    FirstName=rdr.GetString(3),
                    LastName=rdr.GetString(4),
                    IsAdmin=rdr.GetBoolean(5),
                    Deleted=rdr.GetBoolean(6),
                };

                allUsers.Add(temp);
            }

           return allUsers;
        }
    }
}