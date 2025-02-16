using GTT_Gert_Sameys.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GTT_Gert_Sameys.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relations
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Type)
                .WithMany(t => t.Vehicles)
                .HasForeignKey(v => v.VehicleTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.EngineType)
                .WithMany(e => e.Vehicles)
                .HasForeignKey(v => v.EngineTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed initial data for VehicleType
            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType { Id = 1, Name = "Sedan" },
                new VehicleType { Id = 2, Name = "Hatchback" },
                new VehicleType { Id = 3, Name = "Stationwagon" },
                new VehicleType { Id = 4, Name = "SUV" },
                new VehicleType { Id = 5, Name = "Crossover" },
                new VehicleType { Id = 6, Name = "Coupe" },
                new VehicleType { Id = 7, Name = "Cabriolet" },
                new VehicleType { Id = 8, Name = "Pickup Truck" }
            );

            // Seed initial data for EngineType
            modelBuilder.Entity<EngineType>().HasData(
                new EngineType { Id = 1, Name = "Benzine" },
                new EngineType { Id = 2, Name = "Diesel" },
                new EngineType { Id = 3, Name = "Elektrisch" },
                new EngineType { Id = 4, Name = "Hybride" },
                new EngineType { Id = 5, Name = "Plug-in Hybride" },
                new EngineType { Id = 6, Name = "Waterstof" },
                new EngineType { Id = 7, Name = "LPG" },
                new EngineType { Id = 8, Name = "CNG" }
            );
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}