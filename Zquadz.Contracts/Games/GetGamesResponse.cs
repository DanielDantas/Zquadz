using Zquadz.Contracts.Games.Base;

namespace Zquadz.Contracts.Games
{
    public class GetGamesResponse
    {
        public IEnumerable<GameDetails> Games { get; set; }
        public GetGamesResponse(IEnumerable<GameDetails> games) {
            Games = games;
        }
    }
}
