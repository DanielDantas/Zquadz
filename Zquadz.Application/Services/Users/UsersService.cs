using Microsoft.Extensions.Logging;
using Zquadz.Application.Common.Interfaces.Persistance;
using Zquadz.Contracts.Users;

namespace Zquadz.Application.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly ILogger<UsersService> logger;
        private readonly IUsersRepository usersRepository;
        public UsersService(
            ILogger<UsersService> logger,
            IUsersRepository usersRepository)
        {
            this.logger = logger;
            this.usersRepository = usersRepository;
        }

        public Task<GetUsersResponse> GetAll()
        {
            throw new NotImplementedException();
        }
        public async Task<GetUserResponse> GetById(Guid id)
        {
            Domain.Entities.User? user = await this.usersRepository.GetById(id).ConfigureAwait(false);
            if (user is null)
            {
                throw new KeyNotFoundException("User not found");
            }
            return new GetUserResponse
            {
                Id = user.Id,
                Name = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
