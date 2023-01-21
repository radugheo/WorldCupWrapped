using Microsoft.EntityFrameworkCore;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.StadiumRepository
{
    public class StadiumRepository : GenericRepository<Stadium>, IStadiumRepository
    {
        public StadiumRepository(ProjectContext context) : base(context)
        {
        }
        public async Task<List<Stadium>> GetAllStadiums()
        {
            return _table.ToList();
        }
        public async Task<List<Stadium>> GetStadiumsByCity(string city)
        {
            var cities = await _context.Cities.Where(t => t.Name == city).FirstOrDefaultAsync();
            var stadiums = await _context.Stadiums.Where(t => t.CityId == cities.Id).ToListAsync();
            return stadiums;
        }
    }
}