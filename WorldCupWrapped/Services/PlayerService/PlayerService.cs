using AutoMapper;
using WorldCupWrapped.Models.DTOs.Player;
using WorldCupWrapped.Repositories.PlayerRepository;

namespace WorldCupWrapped.Services.PlayerService
{
    public class PlayerService : IPlayerService
    {
        public IPlayerRepository _playerRepository;
        public IMapper _mapper;
        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        
        public async Task<List<PlayerDto>> GetAllPlayers()
        {
            var players = await _playerRepository.GetAllPlayers();
            //test what is in players
            System.Diagnostics.Debug.WriteLine("players: " + players);
            var result = _mapper.Map<List<PlayerDto>>(players);

            return result;
        }

        //delete all players
        public void DeleteAll()
        {
            _playerRepository.DeleteAll();
            _playerRepository.Save();
        }
    }
}
