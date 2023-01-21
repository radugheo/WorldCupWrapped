using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.RefereeRepository
{
    public class RefereeRepository: GenericRepository<Referee>, IRefereeRepository
    {
        public RefereeRepository(ProjectContext context) : base(context)
        {
        }

        public async Task<List<Referee>> GetAllReferees()
        {
            return _table.ToList();
        }
        public async Task<List<Referee>> GetRefereesByNationality(string nationality)
        {
            return await _context.Referees.Where(t => t.Nationality == nationality).ToListAsync();
        }
    }

}
