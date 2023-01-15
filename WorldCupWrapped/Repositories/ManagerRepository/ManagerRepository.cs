using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;
using WorldCupWrapped.Data;

namespace WorldCupWrapped.Repositories.ManagerRepository
{
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(ProjectContext context) : base(context)
        {

        }

        public async Task<List<Manager>> GetAllManagers()
        {
            return await _table.AsNoTracking().ToListAsync();
        }
    }
}