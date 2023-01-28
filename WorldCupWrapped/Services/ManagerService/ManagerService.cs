using AutoMapper;
using WorldCupWrapped.Models.DTOs.Manager;
using WorldCupWrapped.Repositories.ManagerRepository;

namespace WorldCupWrapped.Services.ManagerService
{
    public class ManagerService : IManagerService
    {
        public IManagerRepository _managerRepository;
        public IMapper _mapper;
        public ManagerService(IManagerRepository managerRepository, IMapper mapper)
        {
            _managerRepository = managerRepository;
            _mapper = mapper;
        }
        public async Task<List<ManagerDto>> GetAllManagers()
        {
            var managers = await _managerRepository.GetAllManagers();
            var result = _mapper.Map<List<ManagerDto>>(managers);

            return result;
        }
        public void DeleteAll()
        {
            _managerRepository.DeleteAll();
            _managerRepository.Save();
        }
    }
}
