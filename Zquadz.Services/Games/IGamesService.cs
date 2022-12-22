using Zquadz.Contracts.Games;

namespace Zquadz.Services.Games
{
    public interface IGamesService
    {
        Task<GetGamesResponse> GetGamesResponse();
    }
}
