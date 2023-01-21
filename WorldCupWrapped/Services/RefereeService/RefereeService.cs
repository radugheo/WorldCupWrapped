using AutoMapper;
using WorldCupWrapped.Models.DTOs.Referee;
using WorldCupWrapped.Repositories.RefereeRepository;

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
        public async Task<List<RefereeDto>> GetRefereesByNationality(string nationality)
        {
            var referees = await _refereeRepository.GetRefereesByNationality(nationality);
            var result = _mapper.Map<List<RefereeDto>>(referees);

            return result;
        }
    }
}
