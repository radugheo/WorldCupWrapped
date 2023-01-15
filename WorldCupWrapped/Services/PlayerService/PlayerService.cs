using AutoMapper;
using WorldCupWrapped.Models.DTOs.Player;
using WorldCupWrapped.Repositories.PlayerRepository;

namespace WorldCupWrapped.Services.PlayerService
{
    public class PlayerService : IPlayerService
    {
        public IPlayerRepository _playerRepository;
        public IMapper _mapper;
        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task<List<PlayerDto>> GetAllPlayers()
        {
            var players = await _playerRepository.GetAll();
            List<PlayerDto> result = _mapper.Map<List<PlayerDto>>(players);

            return result;
        }

        Task<List<PlayerDto>> IPlayerService.GetAllPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
