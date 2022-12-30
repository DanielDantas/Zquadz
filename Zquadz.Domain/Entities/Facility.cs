using System.ComponentModel.DataAnnotations.Schema;

namespace Zquadz.Domain.Entities
{
    public class Facility
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
        public string CreatedByName { get; set; } = null!;
        public string LastUpdatedByName { get; set; } = null!;
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public Address Address { get; set; } = null!;
        public double Longitude = 0!;
        public double Latitude = 0!;
        [NotMapped]
        public IEnumerable<Guid> Administrators { get; set; } = Enumerable.Empty<Guid>();
    }
}
