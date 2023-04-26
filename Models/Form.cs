using team11api.Interfaces;
using team11api.Databases;

namespace team11api.Models
{
    public class Form
    {
        public int FormId{get;set;}
        public string Username{get;set;}
        public string IndoorOutdoor{get;set;}
        public string SunExposure{get;set;}
        public string Soil{get;set;}
        public ISaveForm Save{get;set;}
        public Form(){
            Save = new SaveForm();
        }
    }
}