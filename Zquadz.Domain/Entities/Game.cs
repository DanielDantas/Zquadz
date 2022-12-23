using System;
namespace Zquadz.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
    }
}
