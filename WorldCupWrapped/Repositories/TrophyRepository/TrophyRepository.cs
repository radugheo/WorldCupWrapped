using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.TrophyRepository
{
    public class TrophyRepository : GenericRepository<Trophy>, ITrophyRepository
    {
        public TrophyRepository(ProjectContext context) : base(context)
        {
            
        }
        public Trophy FindTrophyByName(string name)
        {
            return _context.Trophies.FirstOrDefault(p => p.Name == name);
        }

        public async Task<List<Trophy>> GetAllTrophies()
        {
            return await _context.Trophies.ToListAsync();
        }
    }
}