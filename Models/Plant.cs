using team11api.Interfaces;
using team11api.Databases;

namespace team11api.Models
{
    public class Plant
    {
        public int PlantId{get;set;}
        public string PlantName{get;set;}
        public string PlantType{get;set;}
        public string Lifespan{get;set;}
        public string IndoorOutdoor{get;set;}
        public string SunExposure{get;set;}
        public string Soil{get;set;}
        public string WateringFreq{get;set;}
        public string ExternalLink{get;set;}
        public string ImageLink{get;set;}
        public decimal Price{get;set;}
        public string Description{get;set;}
        public int InStock{get;set;}
        public bool Deleted{get;set;}
        public ISavePlant Save{get;set;}

        public Plant(){
            Save = new SavePlant();
        }
    }
}