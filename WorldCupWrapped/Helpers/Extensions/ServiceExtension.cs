using WorldCupWrapped.Helpers.JwtUtilsHelpers;
using WorldCupWrapped.Helpers.Seeders;
using WorldCupWrapped.Repositories.CityRepository;
using WorldCupWrapped.Repositories.ManagerRepository;
using WorldCupWrapped.Repositories.MatchRepository;
using WorldCupWrapped.Repositories.PlayerRepository;
using WorldCupWrapped.Repositories.RefereeRepository;
using WorldCupWrapped.Repositories.StadiumRepository;
using WorldCupWrapped.Repositories.TeamRepository;
using WorldCupWrapped.Repositories.TrophyRepository;
using WorldCupWrapped.Repositories.UserRepository;
using WorldCupWrapped.Services.CityService;
using WorldCupWrapped.Services.ManagerService;
using WorldCupWrapped.Services.MatchService;
using WorldCupWrapped.Services.PlayerService;
using WorldCupWrapped.Services.RefereeService;
using WorldCupWrapped.Services.StadiumService;
using WorldCupWrapped.Services.TeamService;
using WorldCupWrapped.Services.TrophyService;
using WorldCupWrapped.Services.UserService;

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
            services.AddTransient<IUserRepository, UserRepository>();
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
            services.AddTransient<IUserService, UserService>();
            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<TrophySeeder>();
            services.AddTransient<CitySeeder>();
            services.AddTransient<ManagerSeeder>();
            services.AddTransient<MatchSeeder>();
            services.AddTransient<RefereeSeeder>();
            services.AddTransient<StadiumSeeder>();
            services.AddTransient<TeamSeeder>();
            services.AddTransient<TeamTrophySeeder>();
            services.AddTransient<TrophySeeder>();
            return services;
        }

        public static IServiceCollection AddUtils(this IServiceCollection services)
        {
            services.AddScoped<IJwtUtils, JwtUtils>();
            return services;
        }
    }
}
