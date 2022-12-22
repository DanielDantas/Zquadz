using Microsoft.AspNetCore.Mvc;
using Zquadz.Application.Services.Games;
using Zquadz.Contracts.Games;

namespace Zquadz.API.Controllers
{
    [ApiController]
    [Route("api/Games")]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<GamesController> logger;
        private readonly IGamesService gamesService;

        public GamesController(
            ILogger<GamesController> logger,
            IGamesService gamesService)
        {
            this.logger = logger;
            this.gamesService = gamesService;
        }

        [HttpGet]
        [Route("All")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(GetGamesResponse), 200)]
        public async Task<ActionResult> GetAll()
        {
            var response = await this.gamesService.GetAll();
            return Ok(response);
        }
    }
}