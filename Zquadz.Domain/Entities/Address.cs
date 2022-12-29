namespace Zquadz.Domain.Entities
{
    public class Address
    {
        public string Country { get; set; } = null!;
        public string State { get; set; } = null!;
        public string County { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
    }
}
