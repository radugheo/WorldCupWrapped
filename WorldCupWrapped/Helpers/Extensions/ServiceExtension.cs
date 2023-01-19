using System.Runtime.CompilerServices;
using WorldCupWrapped.Helpers.Seeders;
using WorldCupWrapped.Repositories.CityRepository;
using WorldCupWrapped.Repositories.ManagerRepository;
using WorldCupWrapped.Repositories.MatchRepository;
using WorldCupWrapped.Repositories.PlayerRepository;
using WorldCupWrapped.Repositories.RefereeRepository;
using WorldCupWrapped.Repositories.StadiumRepository;
using WorldCupWrapped.Repositories.TeamRepository;
using WorldCupWrapped.Repositories.TrophyRepository;
using WorldCupWrapped.Services.CityService;
using WorldCupWrapped.Services.ManagerService;
using WorldCupWrapped.Services.MatchService;
using WorldCupWrapped.Services.PlayerService;
using WorldCupWrapped.Services.RefereeService;
using WorldCupWrapped.Services.StadiumService;
using WorldCupWrapped.Services.TeamService;
using WorldCupWrapped.Services.TrophyService;

namespace WorldCupWrapped.Helpers.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<ITrophyRepository, TrophyRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IManagerRepository, ManagerRepository>();
            services.AddTransient<IMatchRepository, MatchRepository>();
            services.AddTransient<IRefereeRepository, RefereeRepository>();
            services.AddTransient<IStadiumRepository, StadiumRepository>();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<IManagerService, ManagerService>();
            services.AddTransient<IMatchService, MatchService>();
            services.AddTransient<IRefereeService, RefereeService>();
            services.AddTransient<IStadiumService, StadiumService>();
            services.AddTransient<ITrophyService, TrophyService>();
            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<TrophySeeder>();
            return services;
        }

        public static IServiceCollection AddUtils(this IServiceCollection services)
        {
            return services;
        }
    }
}
