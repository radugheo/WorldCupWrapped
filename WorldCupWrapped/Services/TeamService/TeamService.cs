using AutoMapper;
using WorldCupWrapped.Models.DTOs.Team;
using WorldCupWrapped.Models.DTOs.Trophy;
using WorldCupWrapped.Repositories.TeamRepository;

namespace WorldCupWrapped.Services.TeamService
{
    public class TeamService : ITeamService
    {

        public ITeamRepository _teamRepository;
        public IMapper _mapper;
        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }
        public async Task<List<TeamDto>> GetAllTeams()
        {
            var teams = await _teamRepository.GetAllTeams();
            var result = _mapper.Map<List<TeamDto>>(teams);

            return result;
        }
        public async Task<Task> UpdateTeams()
        {
            return _teamRepository.UpdateTeams();
        }
    }
}
