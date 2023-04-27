using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class ReadAllTools : IReadAllTools
    {
        public List<Tool> GetAllTools(){
            List<Tool> allTools = new List<Tool>();

            //make and open connection
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //read command with all data
            string stm = @"SELECT * FROM tools";
            using var cmd = new MySqlCommand(stm,con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Tool temp = new Tool()
                {
                    ToolId=rdr.GetInt32(0),
                    ToolName=rdr.GetString(1),
                    InStock=rdr.GetInt32(2),
                    Price=rdr.GetDecimal(3),
                    ToolDescription=rdr.GetString(4),
                    ImageLink=rdr.GetString(5),
                    Deleted=rdr.GetBoolean(6)
                };

                allTools.Add(temp);
            }

            return allTools;
        }
    }
}