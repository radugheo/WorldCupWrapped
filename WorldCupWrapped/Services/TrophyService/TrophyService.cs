using AutoMapper;
using WorldCupWrapped.Models.DTOs.Trophy;
using WorldCupWrapped.Repositories.TrophyRepository;

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
            var trophies = await _trophyRepository.GetAllTrophies();
            var result = _mapper.Map<List<TrophyDto>>(trophies);

            return result;
        }
    }
}
