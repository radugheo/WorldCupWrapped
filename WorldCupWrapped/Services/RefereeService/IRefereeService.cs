using WorldCupWrapped.Models.DTOs.Referee;

namespace WorldCupWrapped.Services.RefereeService
{
    public interface IRefereeService
    {
        Task<List<RefereeDto>> GetAllReferees();
        Task<List<RefereeDto>> GetRefereesByNationality(string nationality);

    }
}
