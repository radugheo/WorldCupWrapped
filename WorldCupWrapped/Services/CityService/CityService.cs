using AutoMapper;
using WorldCupWrapped.Models.DTOs.City;
using WorldCupWrapped.Repositories.CityRepository;

namespace WorldCupWrapped.Services.CityService
{
    public class CityService : ICityService
    {
        public ICityRepository _cityRepository;
        public IMapper _mapper;
        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public async Task<List<CityDto>> GetAllCities()
        {
            var cities = await _cityRepository.GetAllCities();
            var result = _mapper.Map<List<CityDto>>(cities);

            return result;
        }
        public void DeleteAll()
        {
            _cityRepository.DeleteAll();
            _cityRepository.Save();
        }
    }
}
