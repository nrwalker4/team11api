using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class SaveTool : ISaveTool
    {
        public void CreateTool(Tool myTool)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO tools(toolName, inStock, price, toolDescription, imageLink, deleted) 
            VALUES(@toolName, @inStock, @price, @toolDescription, @imageLink, @deleted)";

            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.Parameters.AddWithValue("@toolName",myTool.ToolName);
            cmd.Parameters.AddWithValue("@inStock",myTool.InStock);
            cmd.Parameters.AddWithValue("@price",myTool.Price);
            cmd.Parameters.AddWithValue("@description",myTool.Description);
            cmd.Parameters.AddWithValue("@imageLink",myTool.ImageLink);
            cmd.Parameters.AddWithValue("@deleted",myTool.Deleted);
        
            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }

        void ISaveTool.SaveTool(Tool myTool)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE tools set toolName=@toolName, inStock=@inStock, price=@price, toolDescription=@toolDescription, imageLink=@imageLink, deleted=@deleted";

            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.CommandText=@"UPDATE tools set toolName=@toolName, inStock=@inStock, price=@price, toolDescription=@toolDescription, imageLink=@imageLink, deleted=@deleted";
            cmd.Parameters.AddWithValue("@toolName",myTool.ToolName);
            cmd.Parameters.AddWithValue("@inStock",myTool.InStock);
            cmd.Parameters.AddWithValue("@price",myTool.Price);
            cmd.Parameters.AddWithValue("@description",myTool.Description);
            cmd.Parameters.AddWithValue("@imageLink",myTool.ImageLink);
            cmd.Parameters.AddWithValue("@deleted",myTool.Deleted);
        
            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}