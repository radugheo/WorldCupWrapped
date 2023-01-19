using AutoMapper;
using WorldCupWrapped.Models.DTOs.Player;
using WorldCupWrapped.Models.DTOs.Trophy;
using WorldCupWrapped.Repositories.PlayerRepository;
using WorldCupWrapped.Repositories.TrophyRepository;
using WorldCupWrapped.Services.PlayerService;

namespace WorldCupWrapped.Services.TrophyService
{
    public class TrophyService : ITrophyService
    {
        public ITrophyRepository _trophyRepository;
        public IMapper _mapper;
        public TrophyService(ITrophyRepository trophyRepository)
        {
            _trophyRepository = trophyRepository;
        }
        public async Task<List<TrophyDto>> GetAllTrophies()
        {
            var players = await _trophyRepository.GetAllTrophies();
            List<TrophyDto> result = _mapper.Map<List<TrophyDto>>(players);

            return result;
        }
    }
}
