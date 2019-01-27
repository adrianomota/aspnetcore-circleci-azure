using Microsoft.EntityFrameworkCore;
using WorshopAspnetCore.Entities;

namespace WorshopAspnetCore
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {
        }

        public DbSet<City> City { get; set; }

        public DbSet<PointOfInterest> PointOfInterest { get; set; }
    }
}