using AutoMapper;
using WorldCupWrapped.Models.DTOs.Referee;
using WorldCupWrapped.Models.DTOs.Trophy;
using WorldCupWrapped.Repositories.RefereeRepository;
using WorldCupWrapped.Repositories.TrophyRepository;

namespace WorldCupWrapped.Services.RefereeService
{
    public class RefereeService : IRefereeService
    {
        public IRefereeRepository _refereeRepository;
        public IMapper _mapper;
        public RefereeService(IRefereeRepository refereeRepository, IMapper mapper)
        {
            _refereeRepository = refereeRepository;
            _mapper = mapper;
        }

        public async Task<List<RefereeDto>> GetAllReferees()
        {
            var referees = await _refereeRepository.GetAllReferees();
            var result = _mapper.Map<List<RefereeDto>>(referees);

            return result;
        }
    }
}
