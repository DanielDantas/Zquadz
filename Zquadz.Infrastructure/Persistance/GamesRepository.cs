﻿using Microsoft.EntityFrameworkCore;
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
        public async Task<Game> GetById(Guid id)
        {
            return await this.context.Games?
                .WithPartitionKey(id.ToString())
                .SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task<Game> Create(Game user)
        {
            this.context.Games?.Add(user);
            await this.context.SaveChangesAsync();
            return await this.GetById(user.Id);
        }
    }
}
