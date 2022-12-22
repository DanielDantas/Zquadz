using Zquadz.Contracts.Games.Base;

namespace Zquadz.Contracts.Games
{
    public class GetGamesResponse
    {
        public List<GameDetails> Games { get; set; }
        public GetGamesResponse(List<GameDetails> games) {
            this.Games = games;
        }
    }
}
