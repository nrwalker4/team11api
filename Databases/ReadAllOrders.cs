using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using team11api.Interfaces;
using team11api.Models;

namespace team11api.Databases
{
    public class ReadAllOrders : IReadAllOrders
    {
        public List<Order> GetAllOrders(){
           List<Order> allOrders = new List<Order>();

           //make and open connection
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //read command with all data
            string stm = @"SELECT * FROM orders";
            using var cmd = new MySqlCommand(stm,con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read()){
                Order temp = new Order(){
                    OrderId=rdr.GetInt32(0),
                    Date=rdr.GetDateTime(1),
                    Username=rdr.GetString(2)
                };
                allOrders.Add(temp);
            }

           return allOrders;
        }
    }
}