using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.StadiumRepository
{
    public interface IStadiumRepository: IGenericRepository<Stadium>
    {
        public Task<List<Stadium>> GetAllStadiums();
        public Task<List<Stadium>> GetStadiumsByCity(string city);
    }
}
