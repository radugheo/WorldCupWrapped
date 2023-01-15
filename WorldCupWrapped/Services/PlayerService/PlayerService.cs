using WorldCupWrapped.Models.DTOs.Player;

namespace WorldCupWrapped.Services.PlayerService
{
    public class PlayerService : IPlayerService
    {
        public IPlayerRepository _playerRepository;
        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public Task<List<PlayerDto>> GetAllPlayers()
        {
            return _playerRepository.GetAll();
        }

        Task<List<PlayerDto>> IPlayerService.GetAllPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
