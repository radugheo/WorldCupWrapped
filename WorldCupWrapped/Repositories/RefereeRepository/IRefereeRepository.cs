using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.RefereeRepository
{
    public interface IRefereeRepository: IGenericRepository<Referee>
    {
        public Task<List<Referee>> GetAllReferees();
    }
}
