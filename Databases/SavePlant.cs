using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class SavePlant : ISavePlant
    {
        public void CreatePlant(Plant myPlant)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO plants(plantName, plantType, lifespan, indoorOutdoor, sunExposure, soil, wateringFreq, externalLink, imageLink, price, plantDescription, inStock) 
            VALUES(@plantName, @plantType, @lifespan, @indoorOutdoor, @sunExposure, @soil, @wateringFreq, @externalLink, @imageLink, @price, @plantDescription, @inStock)";

            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.Parameters.AddWithValue("@plantName",myPlant.PlantName);
            cmd.Parameters.AddWithValue("@plantType",myPlant.PlantType);
            cmd.Parameters.AddWithValue("@lifespan",myPlant.Lifespan);
            cmd.Parameters.AddWithValue("@indoorOutdoor",myPlant.IndoorOutdoor);
            cmd.Parameters.AddWithValue("@sunExposure",myPlant.SunExposure);
            cmd.Parameters.AddWithValue("@soil",myPlant.Soil);
            cmd.Parameters.AddWithValue("@wateringFreq",myPlant.WateringFreq);
            cmd.Parameters.AddWithValue("@externalLink",myPlant.ExternalLink);
            cmd.Parameters.AddWithValue("@imageLink",myPlant.ImageLink);
            cmd.Parameters.AddWithValue("@price",myPlant.Price);
            cmd.Parameters.AddWithValue("@description",myPlant.Description);
            cmd.Parameters.AddWithValue("@inStock",myPlant.InStock);

            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }

        void ISavePlant.SavePlant(Plant myPlant)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE plants set plantName=@plantName, plantType=@plantType, lifespan=@lifespan, indoorOutdoor=@indoorOutdoor, sunExposure=@sunExposure, 
            soil=@soil, wateringFreq=@wateringFreq, externalLink=@externalLink, imageLink=@imageLink, price=@price, plantDescription=@plantDescription, inStock=@inStock";
            
            using var cmd = new MySqlCommand(stm,con);

            cmd.CommandText=@"UPDATE plants set plantName=@plantName, plantType=@plantType, lifespan=@lifespan, indoorOutdoor=@indoorOutdoor, sunExposure=@sunExposure, 
            soil=@soil, wateringFreq=@wateringFreq, externalLink=@externalLink, imageLink=@imageLink, price=@price, plantDescription=@plantDescription, inStock=@inStock";
            cmd.Parameters.AddWithValue("@plantName",myPlant.PlantName);
            cmd.Parameters.AddWithValue("@plantType",myPlant.PlantType);
            cmd.Parameters.AddWithValue("@lifespan",myPlant.Lifespan);
            cmd.Parameters.AddWithValue("@indoorOutdoor",myPlant.IndoorOutdoor);
            cmd.Parameters.AddWithValue("@sunExposure",myPlant.SunExposure);
            cmd.Parameters.AddWithValue("@soil",myPlant.Soil);
            cmd.Parameters.AddWithValue("@wateringFreq",myPlant.WateringFreq);
            cmd.Parameters.AddWithValue("@externalLink",myPlant.ExternalLink);
            cmd.Parameters.AddWithValue("@imageLink",myPlant.ImageLink);
            cmd.Parameters.AddWithValue("@price",myPlant.Price);
            cmd.Parameters.AddWithValue("@description",myPlant.Description);
            cmd.Parameters.AddWithValue("@inStock",myPlant.InStock);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

    }
}