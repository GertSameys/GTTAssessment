namespace GTT_Gert_Sameys.models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}