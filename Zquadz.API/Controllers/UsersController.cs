using Microsoft.AspNetCore.Mvc;
using Zquadz.Application.Services.Users;
using Zquadz.Contracts.Users;

namespace Zquadz.API.Controllers
{
    [ApiController]
    [Route("api/Users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<GamesController> logger;
        private readonly IUsersService usersService;

        public UsersController(
            ILogger<GamesController> logger,
            IUsersService usersService)
        {
            this.logger = logger;
            this.usersService = usersService;
        }

        [HttpGet]
        [Route("{id}")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(GetUserResponse), 200)]
        public async Task<ActionResult> GetById(Guid id)
        {
            var response = await this.usersService.GetById(id);
            return Ok(response);
        }
    }
}