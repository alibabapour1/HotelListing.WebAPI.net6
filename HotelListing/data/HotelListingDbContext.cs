using Microsoft.EntityFrameworkCore;

namespace HotelListing.data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options):base(options) 
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new Country
            {

                CountryId = 1,
                Name = "United States",
                ShortName = "US"

            });
            modelBuilder.Entity<Hotel>().HasData(new Hotel
            {
                HotelId = 1,
                Address = "sdasdasd",
                CountryId = 1,
                Name = "HotelCalifornia",
                Rating = 4.3




            });
        }
    }
}
