using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTT_Gert_Sameys.models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int VehicleTypeId { get; set; }

        [ForeignKey("VehicleTypeId")]
        public VehicleType Type { get; set; }

        [Required]
        public int EngineTypeId { get; set; }

        [ForeignKey("EngineTypeId")]
        public EngineType EngineType { get; set; }
    }
}