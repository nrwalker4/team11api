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

            string stm;

            if(myOLI.PlantId == -1){
                stm = @"INSERT INTO orderlineitem(itemQty, unitPrice, orderID, toolID)
                VALUES(@itemQty, @unitPrice, @orderID, @toolID)";
            }
            else{
                stm = @"INSERT INTO orderlineitem(itemQty, unitPrice, orderID, plantID)
                VALUES(@itemQty, @unitPrice, @orderID, @plantID)";
            }
            
            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.Parameters.AddWithValue("@itemQty",myOLI.ItemQty);
            cmd.Parameters.AddWithValue("@unitPrice",myOLI.UnitPrice);
            cmd.Parameters.AddWithValue("@orderID",myOLI.OrderId);
            cmd.Parameters.AddWithValue("@toolID",myOLI.ToolId);
            cmd.Parameters.AddWithValue("@plantID",myOLI.PlantId);
           
            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}