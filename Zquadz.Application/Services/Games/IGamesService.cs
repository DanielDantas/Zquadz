using Zquadz.Contracts.Games;

namespace Zquadz.Application.Services.Games
{
    public interface IGamesService
    {
        Task<GetGamesResponse> GetAll();
    }
}
