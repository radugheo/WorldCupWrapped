using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.PlayerRepository
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(ProjectContext context) : base(context)
        {
            
        }

        public async Task<List<Player>> GetPlayersByTeam(Guid teamId)
        {
            return await _context.Players.Where(p => p.TeamId == teamId).ToListAsync();
        }

        public Player FindPlayerByName(string name)
        {
            return _context.Players.FirstOrDefault(p => p.Name == name);
        }

        public async Task<List<Player>> GetAllPlayers()
        {
            return await _context.Players.ToListAsync();
        }
    }
}