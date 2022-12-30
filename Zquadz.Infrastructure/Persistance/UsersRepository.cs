using Microsoft.EntityFrameworkCore;
using Zquadz.Application.Common.Interfaces.Persistance;
using Zquadz.Domain.Entities;
using Zquadz.Infrastructure.DbContexts;

namespace Zquadz.Infrastructure.Persistance
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ZquadzContext context;
        public UsersRepository(ZquadzContext context) {
            this.context = context;
        }
        public async Task<User> GetById(Guid id)
        {
            return await this.context.Users?
                .WithPartitionKey(id.ToString())
                .SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task<User> Create(User user)
        {
            this.context.Users?.Add(user);
            this.context.Users?.Add(user);
            await this.context.SaveChangesAsync();
            return await this.GetById(user.Id);
        }
    }
}
