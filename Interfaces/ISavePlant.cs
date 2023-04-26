using team11api.Models;

namespace team11api.Interfaces
{
    public interface ISavePlant
    {
        void CreatePlant(Plant myPlant);
        void SavePlant(Plant myPlant);
    }
}