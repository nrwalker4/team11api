namespace team11api.Models
{
    public class Plant
    {
        public int PlantId{get;set;}
        public string PlantName{get;set;}
        public string Lifespan{get;set;}
        public string IndoorOutdoor{get;set;}
        public string SunExposure{get;set;}
        public string Soil{get;set;}
        public string WateringFreq{get;set;}
        public string ExternalLink{get;set;}
        public string ImageLink{get;set;}
        public int ProductId{get;set;}
        public bool Deleted{get;set;}

        public Plant(){

        }
    }
}