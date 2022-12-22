using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zquadz.Contracts.Address;

namespace Zquadz.Contracts.Games.Base
{
    internal class GameDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public Address.Address Address { get; set; }
        public GameDetails(
            string name,
            string description,
            string type,
            DateTimeOffset startDate,
            DateTimeOffset endDate,
            Address.Address address
        ) {
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Address = address;
        }
    }
}
