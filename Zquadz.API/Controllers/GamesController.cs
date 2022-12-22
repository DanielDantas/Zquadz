using Microsoft.AspNetCore.Mvc;
using Zquadz.Contracts.Games;
using Zquadz.Services.Games;

namespace Zquadz.API.Controllers
{
    [ApiController]
    [Route("api/Games")]
    public class GamesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

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
        public async Task<ActionResult> Get()
        {
            var response = await this.gamesService.GetGamesResponse();
            return Ok(response);
        }
    }
}