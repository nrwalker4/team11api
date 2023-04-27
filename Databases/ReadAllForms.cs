using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class ReadAllForms : IReadAllForms
    {
        public List<Form> GetAllForms(){
           List<Form> allForms = new List<Form>();

           //make and open connection
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //read command with all data

            string stm = @"SELECT formID, indoorOutdoor, sunExposure, soil, IFNULL(username,'N/A') as username FROM forms";
            using var cmd = new MySqlCommand(stm,con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read()){
                Form temp = new Form(){
                    FormId=rdr.GetInt32(0),
                    IndoorOutdoor=rdr.GetString(1),
                    SunExposure=rdr.GetString(2),
                    Soil=rdr.GetString(3),
                    Username=rdr.GetString(4),
                };
                allForms.Add(temp);
            }
           return allForms;
        }
    }
}