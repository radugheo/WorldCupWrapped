using WorldCupWrapped.Models.DTOs.Trophy;

namespace WorldCupWrapped.Services.TrophyService
{
    public interface ITrophyService
    {
        Task<List<TrophyDto>> GetAllTrophies();
    }
}
