using System;
namespace team11api.Models
{
    public class Order
    {
        public int OrderId{get;set;}
        public DateOnly Date{get;set;}
        public string Username{get;set;}
        public Order(){
            
        }

        //order total
    }
}