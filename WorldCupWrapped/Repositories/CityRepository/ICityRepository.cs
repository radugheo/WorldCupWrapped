using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.CityRepository
{
    public interface ICityRepository: IGenericRepository<City>
    {
        City GetCityByName(string name);
    }
}
