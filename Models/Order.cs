using team11api.Interfaces;
using team11api.Databases;

namespace team11api.Models
{
    public class Order
    {
        public int OrderId{get;set;}
        public DateTime Date{get;set;}
        public string Username{get;set;}
        public ISaveOrder Save{get;set;}
        public Order(){
            Save = new SaveOrder();
        }

        //order total
    }
}