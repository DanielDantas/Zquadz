using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Cosmos.Internal;
using Microsoft.Extensions.DependencyInjection;
using Zquadz.Application.Common.Interfaces.Persistance;
using Zquadz.Infrastructure.Settings;
using Zquadz.Infrastructure.DbContexts;
using Zquadz.Infrastructure.Persistance;

namespace Zquadz.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, CosmosSettings cosmosSettings)
        {
            services.AddDbContext<ZquadzContext>((DbContextOptionsBuilder opts) =>
            {
                opts.UseCosmos(
                       cosmosSettings.EndPoint,
                       cosmosSettings.AccessKey,
                       cosmosSettings.DatabaseName);
            });
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<IGamesRepository, GamesRepository>();
            services.AddTransient<IFacilitiesRepository, FacilitiesRepository>();
            return services;
        }
    }
}
