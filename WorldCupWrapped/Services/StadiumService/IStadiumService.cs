using WorldCupWrapped.Models.DTOs.Stadium;

namespace WorldCupWrapped.Services.StadiumService
{
    public interface IStadiumService
    {
        Task<List<StadiumDto>> GetAllStadiums();
    }
}
