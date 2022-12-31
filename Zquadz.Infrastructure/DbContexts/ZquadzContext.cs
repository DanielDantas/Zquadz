using Microsoft.EntityFrameworkCore;
using Zquadz.Domain.Entities;

namespace Zquadz.Infrastructure.DbContexts
{
    public class ZquadzContext : DbContext
    {
        public ZquadzContext(DbContextOptions<ZquadzContext> options)
      : base(options)
        { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Facility> Facilities { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }
            _ = modelBuilder.Entity<User>()
                .HasNoDiscriminator()
                .ToContainer("Users")
                .HasPartitionKey(user => user.Id);

            _ = modelBuilder.Entity<Facility>()
                .HasNoDiscriminator()
                .ToContainer("Facilities")
                .HasPartitionKey(facility => facility.Id);

            _ = modelBuilder.Entity<Game>()
                .HasNoDiscriminator()
                .ToContainer("Games")
                .HasPartitionKey(game => game.FacilityId);
        }
    }
}
