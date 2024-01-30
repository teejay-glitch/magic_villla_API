using MagicVilla_VillaAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Amenity = "",
                    Details = "Details",
                    ImageUrl = "",
                    Name = "Beach Villa",
                    Occupancy = 10,
                    Rate = 20,
                    Sqft = 220,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Amenity = "",
                    Details = "Details",
                    ImageUrl = "",
                    Name = "Beach Villa",
                    Occupancy = 10,
                    Rate = 20,
                    Sqft = 220,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },                
                new Villa
                {
                    Id = 3,
                    Amenity = "",
                    Details = "Details",
                    ImageUrl = "",
                    Name = "Lake Villa",
                    Occupancy = 10,
                    Rate = 20,
                    Sqft = 220,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }

    }
}
