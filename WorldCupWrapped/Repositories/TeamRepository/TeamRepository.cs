using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders.Physical;
using Newtonsoft.Json.Linq;
using System.Net;
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

        public async Task UpdateTeams()
        {
        }
    }
}