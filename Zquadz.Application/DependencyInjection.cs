using Microsoft.Extensions.DependencyInjection;
using Zquadz.Application.Services.Games;
using Zquadz.Application.Services.Users;

namespace Zquadz.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IGamesService, GamesService>();
            services.AddScoped<IUsersService, UsersService>();
            return services;
        }
    }
}
