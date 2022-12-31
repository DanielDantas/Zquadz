using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zquadz.Application.Common.Interfaces.Persistance;
using Zquadz.Infrastructure.Settings;
using Zquadz.Infrastructure.DbContexts;
using Zquadz.Infrastructure.Persistance;

namespace Zquadz.Infrastructure
{
    public static class Injector
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, CosmosSettings cosmosSettings)
        {
            _ = services.AddDbContext<ZquadzContext>((DbContextOptionsBuilder opts) => _ = opts.UseCosmos(
                       cosmosSettings.EndPoint,
                       cosmosSettings.AccessKey,
                       cosmosSettings.DatabaseName));
            _ = services.AddTransient<IUsersRepository, UsersRepository>();
            _ = services.AddTransient<IGamesRepository, GamesRepository>();
            _ = services.AddTransient<IFacilitiesRepository, FacilitiesRepository>();
            return services;
        }
    }
}
