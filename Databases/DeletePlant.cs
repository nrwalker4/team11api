using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class DeletePlant : IDeletePlant
    {
        void IDeletePlant.DeletePlant(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE plants set deleted = @deleted WHERE plantId = @plantId";

            using var cmd = new MySqlCommand(stm,con);
            cmd.CommandText = @"UPDATE plants set deleted = @deleted WHERE plantId = @plantId";
            cmd.Parameters.AddWithValue("@plantId",id);
            cmd.Parameters.AddWithValue("@deleted",true);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

    }
}