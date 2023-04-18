using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class DeleteUser : IDeleteUser
    {
        void IDeleteUser.DeleteUser(string username)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE users set deleted = @deleted WHERE username = @username";

            using var cmd = new MySqlCommand(stm,con);
            cmd.CommandText = @"UPDATE users set deleted = @deleted WHERE username = @username";
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@deleted",true);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}