using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zquadz.Contracts.Base;

namespace Zquadz.Contracts.Games.Base
{
    public class GameDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public Address Address { get; set; }
        public GameDetails(
            string name,
            string description,
            string type,
            DateTimeOffset startDate,
            DateTimeOffset endDate,
            Address address
        ) {
            Name = name;
            Description = description;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Address = address;
        }
    }
}
