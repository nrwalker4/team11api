namespace team11api.Models
{
    public class Product
    {
        public int ProductId{get;set;}
        public string ProductName{get;set;}
        public int InStock{get;set;}
        public decimal Price{get;set;}
        public string ProductDescription{get;set;}
        public string ImageLink{get;set;}
        public string OLId{get;set;}
        public bool Deleted{get;set;}

        public Product(){

        }
    }
}