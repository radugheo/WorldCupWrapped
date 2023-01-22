using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.MatchRepository
{
    public interface IMatchRepository : IGenericRepository<Match>
    {
        public Task<List<Match>> GetAllMatches();

        public Task<List<Match>> GetMatchesByGroup(string group);
    }
}