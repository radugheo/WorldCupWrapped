using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.TeamRepository
{
    public interface ITeamRepository: IGenericRepository<Team>
    {
        public Task<List<Team>> GetTeamsByGroup(string group);
        
        public Task<List<Team>> GetTeamsByGroupAndPosition(string group, string groupRanking);

        public Task<List<Team>> GetAllTeams();

        public Task UpdateTeams();
    }
}
