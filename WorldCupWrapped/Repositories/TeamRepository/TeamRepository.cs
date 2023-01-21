using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.TeamRepository
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(ProjectContext context) : base(context)
        {
        }

        public async Task<List<Team>> GetTeamsByGroup(string group)
        {
            return await _context.Teams.Where(t => t.Group == group).ToListAsync();
        }

        public async Task<List<Team>> GetTeamsByGroupAndPosition(string group, string position)
        {
            return await _context.Teams.Where(t => t.Group == group && t.GroupRanking == position).ToListAsync();
        }

        public async Task<List<Team>> GetAllTeams()
        {
            return _table.ToList();
        }
        public async Task<List<TrophyCount>> GetTeamTrophies(string teamName)
        {
            var team = await _context.Teams.Where(t => t.FifaName == teamName).FirstOrDefaultAsync();
            var teamTrophies = await _context.TeamTrophies.Where(t => t.TeamId == team.Id).ToListAsync();
            var trophies = new List<TrophyCount>();
            foreach (var trophy in teamTrophies)
            {
                var trophyName = await _context.Trophies.Where(t => t.Id == trophy.TrophyId).FirstOrDefaultAsync();
                var trophyCountAdd = new TrophyCount
                {
                    Trophy = trophyName,
                    Count = trophy.Count
                };
                trophies.Add(trophyCountAdd);
            }
            return trophies;
        }
    }
}