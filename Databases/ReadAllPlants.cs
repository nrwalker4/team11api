using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class ReadAllPlants : IReadAllPlants
    {
        public List<Plant> GetAllPlants()
        {
            List<Plant> allPlants = new List<Plant>();

            //make and open connection
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //read command with all data
            string stm = @"SELECT * FROM plants";
            using var cmd = new MySqlCommand(stm,con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Plant temp = new Plant()
                {
                    PlantId=rdr.GetInt32(0),
                    PlantName = rdr.GetString(1),
                    Lifespan=rdr.GetString(2),
                    IndoorOutdoor=rdr.GetString(3),
                    SunExposure=rdr.GetString(4),
                    Soil=rdr.GetString(5),
                    WateringFreq=rdr.GetString(6),
                    ExternalLink=rdr.GetString(7),
                    ImageLink=rdr.GetString(8),
                    ProductId=rdr.GetInt32(9),
                    Deleted=rdr.GetBoolean(10)
                };
                allPlants.Add(temp);
            }

            return allPlants;
        }
    }
}