using AutoMapper;
using WorldCupWrapped.Models.DTOs.Stadium;
using WorldCupWrapped.Repositories.StadiumRepository;

namespace WorldCupWrapped.Services.StadiumService
{
    public class StadiumService : IStadiumService
    {
        public IStadiumRepository _stadiumRepository;
        public IMapper _mapper;
        public StadiumService(IStadiumRepository stadiumRepository, IMapper mapper)
        {
            _stadiumRepository = stadiumRepository;
            _mapper = mapper;
        }
        public async Task<List<StadiumDto>> GetAllStadiums()
        {
            var stadiums = await _stadiumRepository.GetAllStadiums();
            var result = _mapper.Map<List<StadiumDto>>(stadiums);

            return result;
        }
        public async Task<List<StadiumDto>> GetStadiumsByCity(string city)
        {
            var stadiums = await _stadiumRepository.GetStadiumsByCity(city);
            var result = _mapper.Map<List<StadiumDto>>(stadiums);

            return result;
        }
    }
}
