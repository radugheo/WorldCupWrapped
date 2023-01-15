using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.CityRepository
{
    public class CityRepository: GenericRepository<City>, ICityRepository
    {
        public CityRepository(ProjectContext context) : base(context)
        {
            
        }
        public City GetCityByName(string name)
        {
            return _context.Cities.FirstOrDefault(c => c.Name == name);
        }
    }
}
