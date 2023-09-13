using Anababi.ModelClasses;
using Microsoft.EntityFrameworkCore;

namespace Anababi.Data
{
    public class AnababiContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Reference> References { get; set; } = null!;
        public DbSet<PhysicalReference> PhysicalReferences { get; set; } = null!;
        public DbSet<DigitalReference> DigitalReferences { get; set; } = null!;
        public DbSet<Library> Libraries { get; set; } = null!;
        public DbSet<Creator> Creators { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"server = .; 
                database = AnababiLMS; 
                integrated security = true; 
                encrypt = false"
            );
        }

    }
}
