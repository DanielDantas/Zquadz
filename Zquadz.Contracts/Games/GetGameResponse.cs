using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zquadz.Contracts.Games.Base;

namespace Zquadz.Contracts.Games
{
    internal class GetGameResponse : GameDetails
    {
        public GetGameResponse(string name, string description, string type, DateTimeOffset startDate, DateTimeOffset endDate, Address.Address address) : base(name, description, type, startDate, endDate, address)
        {
        }
    }
}
