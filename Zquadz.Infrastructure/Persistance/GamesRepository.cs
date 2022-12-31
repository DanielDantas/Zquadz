using Microsoft.EntityFrameworkCore;
using Zquadz.Application.Common.Interfaces.Persistance;
using Zquadz.Domain.Entities;
using Zquadz.Infrastructure.DbContexts;

namespace Zquadz.Infrastructure.Persistance
{
    public class GamesRepository: IGamesRepository
    {
        private readonly ZquadzContext context;
        public GamesRepository(ZquadzContext context)
        {
            this.context = context;
        }
        public async Task<Game?> GetById(Guid id)
        {
            return await this.context.Games
                .WithPartitionKey(id.ToString())
                .SingleOrDefaultAsync(d => d.Id == id).ConfigureAwait(false);
        }

        public async Task<Game> Create(Game game)
        {
            if (game is null)
            {
                throw new ArgumentNullException(nameof(game));
            }

            _ = (this.context.Games?.Add(game));
            _ = await this.context.SaveChangesAsync().ConfigureAwait(false);
            return game;
        }
    }
}
