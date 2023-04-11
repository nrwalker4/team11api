
namespace team11api


{
    public class ConnectionString
    {
        public string cs {get; set;}
        //Connects to database
        public ConnectionString(){
            string server = "pk1l4ihepirw9fob.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "hy98rdasbboybciv";
            string port = "3306";
            string username = "cwa4nj1pjt0jjnmy";
            string password = "bvv8f3jdwxpa7215";

            cs = $"server = {server};user = {username};database = {database};port = {port};password = {password};";
        }
    }
}