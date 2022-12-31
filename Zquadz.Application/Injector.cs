using Microsoft.Extensions.DependencyInjection;
using Zquadz.Application.Services.Games;
using Zquadz.Application.Services.Users;
namespace Zquadz.Application
{
    public static class Injector
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            _ = services.AddScoped<IGamesService, GamesService>();
            _ = services.AddScoped<IUsersService, UsersService>();
            return services;
        }
    }
}
