using WorldCupWrapped.Models.DTOs.City;
using WorldCupWrapped.Models.DTOs.Manager;

namespace WorldCupWrapped.Services.CityService
{
    public interface ICityService
    {
        Task<List<CityDto>> GetAllCities();
        void DeleteAll();
    }
}
