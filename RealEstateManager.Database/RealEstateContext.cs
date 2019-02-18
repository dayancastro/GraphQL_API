using Microsoft.EntityFrameworkCore;
using RealEstateManager.Database.Models;

namespace RealEstateManager.Database
{
    public class RealEstateContext : DbContext
    {
        public RealEstateContext(DbContextOptions<RealEstateContext> options) : base(options)
        {

        }

        public DbSet<Database.Models.Property> Properties { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PropertyOwner> PropertyOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyOwner>().HasKey(po => new { po.OwnerId, po.PropertyId });
        }

    }
}
