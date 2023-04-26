using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class SaveOLI : ISaveOLI
    {
        public void CreateOLI(OLI myOLI)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO forms(itemQty, unitPrice, orderID, toolID, plantID)
            VALUES(@itemQty, @unitPrice, @orderID, @toolID, @plantID)";

            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.Parameters.AddWithValue("@indoorOutdoor",myOLI.ItemQty);
            cmd.Parameters.AddWithValue("@indoorOutdoor",myOLI.UnitPrice);
            cmd.Parameters.AddWithValue("@indoorOutdoor",myOLI.OrderId);
            cmd.Parameters.AddWithValue("@indoorOutdoor",myOLI.ToolId);
            cmd.Parameters.AddWithValue("@indoorOutdoor",myOLI.PlantId);
           
            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}