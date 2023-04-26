using team11api.Interfaces;
using team11api.Databases;

namespace team11api.Models
{
    public class OLI
    {
        public int OLId{get;set;}
        public int ItemQty{get;set;}
        public decimal UnitPrice{get;set;}
        public int OrderId{get;set;}
        public int PlantId{get;set;}
        public int ToolId{get;set;}
        public ISaveOLI Save{get;set;}
        public OLI(){
            Save = new SaveOLI();
        }
        //subtotal
    }
}