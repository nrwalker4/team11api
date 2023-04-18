using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class DeleteTool : IDeleteTool
    {
        void IDeleteTool.DeleteTool(int id)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE tools set deleted = @deleted WHERE toolId = @toolId";

            using var cmd = new MySqlCommand(stm,con);
            cmd.CommandText = @"UPDATE tools set deleted = @deleted WHERE toolId = @toolId";
            cmd.Parameters.AddWithValue("@toolId",id);
            cmd.Parameters.AddWithValue("@deleted",true);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}