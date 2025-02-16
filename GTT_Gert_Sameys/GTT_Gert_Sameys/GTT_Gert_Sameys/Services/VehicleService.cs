using GTT_Gert_Sameys.models;
using Microsoft.EntityFrameworkCore;

namespace GTT_Gert_Sameys.Services
{
    public class VehicleService : IVehicleService
    {
        public void AddVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        private readonly DbContext _context;

        public VehicleService(DbContext context)
        {
            _context = context;
        }
    }
}