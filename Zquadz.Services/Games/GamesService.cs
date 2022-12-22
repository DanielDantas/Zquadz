using Microsoft.Extensions.Logging;
using Zquadz.Contracts.Games;

namespace Zquadz.Services.Games
{
    public class GamesService: IGamesService
    {
        private readonly ILogger logger;
        public GamesService(ILogger<GamesService> logger) { 
            this.logger = logger;
        }

        public Task<GetGamesResponse> GetGamesResponse()
        {
            throw new NotImplementedException();
        }
    }
}
