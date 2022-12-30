using System.ComponentModel.DataAnnotations.Schema;

namespace Zquadz.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FacilityId { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
        public string CreatedByName { get; set; } = null!;
        public string LastUpdatedByName { get; set; } = null!;
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public short NumberOfPlayersLimit { get; set; }
        [NotMapped]
        public IEnumerable<Guid> Players { get; set; } = Enumerable.Empty<Guid>();
        public Address Address { get; set; } = null!;
        public double Longitude = 0!;
        public double Latitude = 0!;
    }
}
