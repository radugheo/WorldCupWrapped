using Microsoft.AspNetCore.Mvc;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.TeamRepository
{
    public interface ITeamRepository: IGenericRepository<Team>
    {
        public Task<List<Team>> GetTeamsByGroup(string group);
        
        public Task<List<Team>> GetTeamsByGroupAndPosition(string group, string groupRanking);

        public Task<List<Team>> GetAllTeams();
        public Task<List<TrophyCount>> GetTeamTrophies(string teamName);
        public void DeleteTeamsByGroup(string group);
    }
}
