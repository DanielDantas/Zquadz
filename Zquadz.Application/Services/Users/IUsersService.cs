using Zquadz.Contracts.Games;
using Zquadz.Contracts.Users;

namespace Zquadz.Application.Services.Users
{
    public interface IUsersService
    {
        Task<GetUsersResponse> GetAll();
        Task<GetUserResponse> GetById(Guid id);
    }
}
