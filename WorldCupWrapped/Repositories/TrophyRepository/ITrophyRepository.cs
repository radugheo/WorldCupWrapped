using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.TrophyRepository
{
    public interface ITrophyRepository: IGenericRepository<Trophy>
    {
        Trophy FindTrophyByName(string name);
        public Task<List<Trophy>> GetAllTrophies();
    }
}
