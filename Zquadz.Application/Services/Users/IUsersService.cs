using Zquadz.Contracts.Games;

namespace Zquadz.Application.Services.Users
{
    public interface IUsersService
    {
        Task<GetGamesResponse> GetAll();
    }
}
