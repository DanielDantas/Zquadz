using Microsoft.Extensions.Logging;
using Zquadz.Contracts.Games;

namespace Zquadz.Application.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly ILogger logger;
        public UsersService(ILogger<UsersService> logger)
        {
            this.logger = logger;
        }

        public Task<GetGamesResponse> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
