using Microsoft.EntityFrameworkCore;
using Zquadz.Application.Common.Interfaces.Persistance;
using Zquadz.Domain.Entities;
using Zquadz.Infrastructure.DbContexts;

namespace Zquadz.Infrastructure.Persistance
{
    public class FacilitiesRepository : IFacilitiesRepository
    {
        private readonly ZquadzContext context;
        public FacilitiesRepository(ZquadzContext context)
        {
            this.context = context;
        }
        public async Task<Facility> GetById(Guid id)
        {
            return await this.context.Facilities?
                .WithPartitionKey(id.ToString())
                .SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task<Facility> Create(Facility facility)
        {
            this.context.Facilities?.Add(facility);
            await this.context.SaveChangesAsync();
            return await this.GetById(facility.Id);
        }
    }
}
