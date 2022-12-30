using Microsoft.EntityFrameworkCore;
using Zquadz.Domain.Entities;

namespace Zquadz.Infrastructure.DbContexts
{
    public class ZquadzContext : DbContext
    {
        public ZquadzContext()
        {

        }
        public ZquadzContext(DbContextOptions<ZquadzContext> options)
      : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasNoDiscriminator()
                .ToContainer("Users")
                .HasPartitionKey(user => user.Id);

            modelBuilder.Entity<Facility>()
                .HasNoDiscriminator()
                .ToContainer("Facilities")
                .HasPartitionKey(facility => facility.Id);

            modelBuilder.Entity<Game>()
                .HasNoDiscriminator()
                .ToContainer("Games")
                .HasPartitionKey(game => game.FacilityId);
        }
    }
}
