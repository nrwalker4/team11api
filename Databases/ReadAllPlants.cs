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
                    PlantType=rdr.GetString(2),
                    Lifespan=rdr.GetString(3),
                    IndoorOutdoor=rdr.GetString(4),
                    SunExposure=rdr.GetString(5),
                    Soil=rdr.GetString(6),
                    WateringFreq=rdr.GetString(7),
                    ExternalLink=rdr.GetString(8),
                    ImageLink=rdr.GetString(9),
                    Price=rdr.GetDecimal(10),
                    Description=rdr.GetString(11),
                    InStock=rdr.GetInt32(12),
                    Deleted=rdr.GetBoolean(13)
                };
                allPlants.Add(temp);
            }

            return allPlants;
        }
    }
}