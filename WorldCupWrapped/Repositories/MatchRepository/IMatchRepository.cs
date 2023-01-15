using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.MatchRepository
{
    public interface IMatchRepository : IGenericRepository<Match>
    {
        //public Task<List<Match>> GetMatchesByTeamId(Guid teamId);
    }
}