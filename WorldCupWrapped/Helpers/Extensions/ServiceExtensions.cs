using WorldCupWrapped.Repositories.PlayerRepository;
using WorldCupWrapped.Services.PlayerService;

namespace WorldCupWrapped.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPlayerRepository, PlayerRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPlayerService, PlayerService>();

            return services;
        }
    }
}