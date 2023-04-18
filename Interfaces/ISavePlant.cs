using team11api.Models;

namespace team11api.Interfaces
{
    public interface ISavePlant
    {
        public void CreatePlant(Plant myPlant);
        public void SavePlant(Plant myPlant);
    }
}