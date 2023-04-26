using team11api.Models;

namespace team11api.Interfaces
{
    public interface ISaveTool
    {
        void CreateTool(Tool myTool);
        void SaveTool(Tool myTool);
    }
}