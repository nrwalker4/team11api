using team11api.Models;

namespace team11api.Interfaces
{
    public interface ISaveTool
    {
        public void CreateTool(Tool myTool);
        public void SaveTool(Tool myTool);
    }
}