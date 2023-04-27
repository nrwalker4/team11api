using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class SaveForm : ISaveForm
    {
        public void CreateForm(Form myForm){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm;

            if(myForm.Username != "N/A"){
                stm = @"INSERT INTO forms(indoorOutdoor, sunExposure, soil, username)
                VALUES(@indoorOutdoor, @sunExposure, @soil, @username)";
            }
            else{
                stm = @"INSERT INTO forms(indoorOutdoor, sunExposure, soil)
                VALUES(@indoorOutdoor, @sunExposure, @soil)";
            }

            using var cmd = new MySqlCommand(stm,con);

            //prepared statements
            cmd.Parameters.AddWithValue("@indoorOutdoor",myForm.IndoorOutdoor);
            cmd.Parameters.AddWithValue("@sunExposure",myForm.SunExposure);
            cmd.Parameters.AddWithValue("@soil",myForm.Soil);
            cmd.Parameters.AddWithValue("@username",myForm.Username);

            //execute prepare: will take parameters and statement and check for anything bad
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}