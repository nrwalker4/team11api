using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class ReadAllOLIs : IReadAllOLIs
    {
        public List<OLI> GetAllOLIs(){
           List<OLI> allOLIs = new List<OLI>();

           //make and open connection
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //read command with all data
            string stm = @"SELECT * FROM orderlineitem";
            using var cmd = new MySqlCommand(stm,con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read()){
                OLI temp = new OLI(){
                    OLId=rdr.GetInt32(0),
                    ItemQty=rdr.GetInt32(1),
                    UnitPrice=rdr.GetInt32(2),
                    OrderId=rdr.GetInt32(3),
                    ToolId=rdr.GetInt32(4),
                    PlantId=rdr.GetInt32(5),
                };
                allOLIs.Add(temp);
            }

           return allOLIs;
        }
    }
}