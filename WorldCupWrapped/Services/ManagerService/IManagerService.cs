using WorldCupWrapped.Models.DTOs.Manager;

namespace WorldCupWrapped.Services.ManagerService
{
    public interface IManagerService
    {
        Task<List<ManagerDto>> GetAllManagers();
        void DeleteAll();
    }
}
