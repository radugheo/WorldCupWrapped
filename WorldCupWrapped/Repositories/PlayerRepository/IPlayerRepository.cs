using WorldCupWrapped.Models;
using WorldCupWrapped.Repository.GenericRepository;

namespace WorldCupWrapped.Repositories.PlayerRepository
{
    public interface IPlayerRepository: IGenericRepository<Player>
    {
        public Task<List<Player>> GetPlayersByTeam(Guid teamId);
        Player FindPlayerByName(string name);
        public Task<List<Player>> GetAllPlayers();
    }
}
