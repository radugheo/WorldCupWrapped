using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.ManagerRepository
{
    public interface IManagerRepository: IGenericRepository<Manager>
    {
        public Task<List<Manager>> GetAllManagers();
        
    }
}
