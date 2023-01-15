using WorldCupWrapped.Models.DTOs.Team;

namespace WorldCupWrapped.Services.TeamService
{
    public class TeamService : ITeamService
    {
        /*
        public ITeamRepository _teamRepository;
        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public Task<List<TeamDto>> GetAllTeams()
        {
            return _teamRepository.GetAll();
        }
        public async Task DeleteTeam(Guid teamId)
        {
            var teamToDelete = await _teamRepository.FindByIdAsync(teamId);
            _teamRepository.Delete(teamToDelete);
            await _teamRepository.SaveAsync();
        }
        */
    }
}
