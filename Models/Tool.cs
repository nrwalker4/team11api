using team11api.Interfaces;
using team11api.Databases;

namespace team11api.Models
{
    public class Tool
    {
        public int ToolId{get;set;}
        public string ToolName{get;set;}
        public int InStock{get;set;}
        public decimal Price{get;set;}
        public string ToolDescription{get;set;}
        public string ImageLink{get;set;}
        public bool Deleted{get;set;}
        public ISaveTool Save{get;set;}
        public Tool(){
            Save = new SaveTool();
        }
    }
}