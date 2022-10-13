using Microsoft.EntityFrameworkCore;

namespace UsedCarsListingAPI.Models
{
    public class CarsListingContext :  DbContext
    {
        public CarsListingContext(DbContextOptions<CarsListingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CarItem> CarItems { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
