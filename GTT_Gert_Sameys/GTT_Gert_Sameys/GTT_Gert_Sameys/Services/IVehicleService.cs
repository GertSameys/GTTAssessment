using GTT_Gert_Sameys.models;

namespace GTT_Gert_Sameys.Services
{
    public interface IVehicleService
    {
        public void AddVehicle(Vehicle vehicle);

        public void UpdateVehicle(Vehicle vehicle);

        public void DeleteVehicle(int id);

        public Vehicle GetVehicle(int id);

        public List<Vehicle> GetVehicles();
    }
}