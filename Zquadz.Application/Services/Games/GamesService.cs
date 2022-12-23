using Microsoft.Extensions.Logging;
using Zquadz.Contracts.Games;

namespace Zquadz.Application.Services.Games
{
    public class GamesService : IGamesService
    {
        private readonly ILogger logger;
        public GamesService(ILogger<IGamesService> logger)
        {
            this.logger = logger;
        }

        public Task<GetGamesResponse> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
