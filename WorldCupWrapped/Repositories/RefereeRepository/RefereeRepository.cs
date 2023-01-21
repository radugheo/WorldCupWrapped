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
    }
}
