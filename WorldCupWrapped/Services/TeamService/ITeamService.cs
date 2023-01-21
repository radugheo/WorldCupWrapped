using WorldCupWrapped.Models.DTOs.Team;
using WorldCupWrapped.Models.DTOs.TrophyCount;

namespace WorldCupWrapped.Services.TeamService
{
    public interface ITeamService
    {
        public Task<List<TeamDto>> GetTeamsByGroup(string group);
        public Task<List<TeamDto>> GetTeamsByGroupAndPosition(string group, string groupRanking);
        Task<List<TeamDto>> GetAllTeams();
        public Task<List<TrophyCountDto>> GetTeamTrophies(string teamName);
    }
}
