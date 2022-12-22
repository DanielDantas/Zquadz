using Zquadz.Contracts.Games.Base;

namespace Zquadz.Contracts.Games
{
    public class GetGameResponse : GameDetails
    {
        public GetGameResponse(string name, string description, string type, DateTimeOffset startDate, DateTimeOffset endDate, Address.Address address) : base(name, description, type, startDate, endDate, address)
        {
        }
    }
}
