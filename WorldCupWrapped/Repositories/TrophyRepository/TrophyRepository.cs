using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.TrophyRepository
{
    public class TrophyRepository : GenericRepository <Trophy>, ITrophyRepository
    {
        public TrophyRepository(ProjectContext context) : base(context)
        {
        }
        public async Task<List<Trophy>> GetAllTrophies()
        {
           return _table.ToList();
        }
    }
}