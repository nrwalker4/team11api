namespace team11api.Models
{
    public class Tool
    {
        public int ToolId{get;set;}
        public string ToolName{get;set;}
        public int InStock{get;set;}
        public decimal Price{get;set;}
        public string Description{get;set;}
        public string ImageLink{get;set;}
        public bool Deleted{get;set;}
        public Tool(){

        }

    }
}