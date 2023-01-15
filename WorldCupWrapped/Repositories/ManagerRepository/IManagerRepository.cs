using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.ManagerRepository
{
    public interface IManagerRepository: IGenericRepository<Manager>
    {
        Task<List<Manager>> GetAllManagers();
        
    }
}
